using System;

class BinaryToDecimal
{
    static long BinaryToDecimalConvert(string binary)
    {
        long decimalNumber = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            long temp = binary[i] - '0';
            int power = binary.Length - i - 1;
            long powerOfTwo = (long)Math.Pow(2, power);
            decimalNumber += powerOfTwo * (binary[i] - '0');
        }
        return decimalNumber;
    }

    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        Console.WriteLine(BinaryToDecimalConvert(binaryNumber));
    }
}