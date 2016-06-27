﻿namespace BankAccounts.Accounts
{
    using Customer;
    using Interfaces;
    using System;
    using System.Reflection;

    public abstract class Account : IRate, IDeposit
    {
        private decimal rate;

        protected Account(Customer customer, decimal balance, decimal rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = rate;
            this.SetCustomerType(customer.GetType());
        }

        public Customer Customer { get; protected set; }

        public decimal Balance { get; set; }

        public decimal InterestRate
        {
            get
            {
                return this.rate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"Interest rate must be over 0.00");
                }
                this.rate = value;
            }
        }

        protected CustomerType CustomerType { get; private set; }

        public decimal CalculateInterest(int period)
        {
            const string format = "Calculate{0}Interest";
            var name = string.Format(format, this.Customer.GetType().Name);
            var method = this.GetType()
                .GetMethod(name, BindingFlags.NonPublic | BindingFlags.Instance);

            var result = (decimal)method.Invoke(this, new object[] { period });

            return result;
        }

        protected abstract decimal CalculateIndividualInterest(int period);

        protected abstract decimal CalculateCompanyInterest(int period);

        public virtual void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        private void SetCustomerType(Type type)
        {
            CustomerType temp;
            if (Enum.TryParse(type.Name, out temp)) this.CustomerType = temp;
            else throw new ArgumentException("Invalid Customer Type");
        }
    }
}
