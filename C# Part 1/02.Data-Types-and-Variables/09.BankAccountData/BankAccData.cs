using System;

namespace _09.BankAccountData
{
    class BankAccData
    {
        static void Main()
        {
            string holderName = "Gabriel Omar Batistuta";
            float balance = 1592.68f;
            string bankName = "FiBank";
            string iban = "AR61 1904 3002 3457 3201";
            short securityNumber = 909;

            Console.WriteLine("Holder: " + holderName);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Bank: " + bankName);
            Console.WriteLine("IBAN: " + iban);
            Console.WriteLine("Security number: " + securityNumber);
        }
    }
}
