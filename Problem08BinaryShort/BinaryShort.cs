//Problem 8. Binary short• Write a program that shows the binary representation of given 16-bit signed integer number (the C# type  short ).

using System;
using System.Collections.Generic;
using System.Text;

class BinaryShort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please,enter a short number between {0} and {1}", short.MinValue, short.MaxValue);
        int decimalNumber = int.Parse(Console.ReadLine());
       

        if (decimalNumber < 0)
        {
            decimalNumber = (short)(short.MinValue ^ decimalNumber);
            Console.WriteLine("1" + ShortToBin(decimalNumber).PadLeft(15, '0'));
        }
        else if (decimalNumber == 0)
        {
            Console.WriteLine(decimalNumber);
        }
        else
        {
            Console.WriteLine(ShortToBin(decimalNumber).PadLeft(16,'0'));
        }

    }
    static string ShortToBin(int decimalNumber)
    {
        StringBuilder binary = new StringBuilder();
        while (decimalNumber != 0)
        {
            binary.Insert(0, Convert.ToString(decimalNumber % 2));
            decimalNumber /= 2;
        }
        return Convert.ToString(binary);
    }
}
