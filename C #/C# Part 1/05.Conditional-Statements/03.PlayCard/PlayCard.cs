using System;

namespace _03.PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            string card = Console.ReadLine();

            switch (card)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "Q":
                case "K":
                case "J":
                case "A":
                Console.WriteLine("yes " + card); break;
                default:
                Console.WriteLine("no " + card); break;
            }
        }
    }
}
