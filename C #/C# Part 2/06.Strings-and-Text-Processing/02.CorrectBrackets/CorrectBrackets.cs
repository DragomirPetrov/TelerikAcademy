using System;

class CorrectBrackets
{
    static void Main()
    {
        string check = Console.ReadLine();

        string correct = "Correct";
        string incorrect = "Incorrect";

        int openBrackets = 0;
        int closeBrackets = 0;

        foreach (var element in check)
        {
            if (element == '(')
            {
                openBrackets++;

                continue;
            }
            if (element == ')')
            {
                closeBrackets++;

                continue;
            }
        }

        if (openBrackets == closeBrackets)
        {
            Console.WriteLine(correct);
        }
        else
        {
            Console.WriteLine(incorrect);
        }
    }
}