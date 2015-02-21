//Problem 4. Hexadecimal to decimal• Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please, enter a hexadecimal number");
        string hexaDecimal = Console.ReadLine();
        long rezult = 0;
        int numberDecimal = 0;

        for (int i = hexaDecimal.Length - 1; i >= 0; i--)
        {
            int number;
            string str = Convert.ToString(hexaDecimal[i]);

            if (int.TryParse(str, out number))
            {
                rezult += number * (long)Math.Pow(16, hexaDecimal.Length - i - 1);
            }
            else
            {
                switch (str)
                {
                    case "A": numberDecimal = 10; break;
                    case "B": numberDecimal = 11; break;
                    case "C": numberDecimal = 12; break;
                    case "D": numberDecimal = 13; break;
                    case "E": numberDecimal = 14; break;
                    case "F": numberDecimal = 15; break;
                }
                rezult += numberDecimal * (long)Math.Pow(16, hexaDecimal.Length - i - 1);
            }
        }
        Console.WriteLine(rezult);
    }
}