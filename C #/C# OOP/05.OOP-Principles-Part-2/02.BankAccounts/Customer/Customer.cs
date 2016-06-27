namespace BankAccounts.Customer
{
    using System;

    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid customer name");
                }
                else if (value.Length > 30)
                {
                    throw new ArgumentException("Customer's name is too long");
                }
                this.name = value;
            }
        }
    }
}
