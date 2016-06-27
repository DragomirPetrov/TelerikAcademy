namespace BankAccounts
{
    using System;

    public class Test
    {
        public static void Main()
        {
            var test = new Accounts.Deposit(
            new Customer.Company("Telerik"),
                                  2300, (decimal)2.3);

            Console.WriteLine(test.GetType().Name);
            Console.WriteLine("Account balance: {0}", test.Balance);
            Console.WriteLine("Account interest rate: {0}", test.InterestRate);
            Console.WriteLine("Interest calculation: {0}", test.CalculateInterest(23));
        }
    }
}
