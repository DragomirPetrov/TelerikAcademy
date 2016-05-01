using System;


class Program
{
    static void Main()
    {
        string cardSign = Console.ReadLine();
        int n = 0;

        switch (cardSign)
        {
            case "2": n += 2; break;
            case "3": n += 3; break;
            case "4": n += 4; break;
            case "5": n += 5; break;
            case "6": n += 6; break;
            case "7": n += 7; break;
            case "8": n += 8; break;
            case "9": n += 9; break;
            case "10": n += 10; break;
            case "J": n += 11; break;
            case "Q": n += 12; break;
            case "K": n += 13; break;
            case "A": n += 14; break;

            default:
                break;
        }


        for (int i = 2; i <= n; i++)
        {
            if (i < 11)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }
            else if (i == 11)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
            }
            else if (i == 12)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
            }
            else if (i == 13)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
            }
            else if (i == 14)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "A");
            }
        }
    }
}