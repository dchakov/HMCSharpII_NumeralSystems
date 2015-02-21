//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem01DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Please,enter a decimal number [long.MinValue...long.MaxValue]");  // -3 , 3 
            long numberDecimal = long.Parse(Console.ReadLine());
            StringBuilder binary = new StringBuilder();

            if (numberDecimal < 0)
            {
                numberDecimal = numberDecimal ^ long.MinValue;

            }
            if (numberDecimal == 0)
            {
                Console.WriteLine(numberDecimal);
            }
            else
            {
                while (numberDecimal != 0)
                {
                    binary.Insert(0, Convert.ToString(numberDecimal % 2));
                    numberDecimal /= 2;
                }
                Console.WriteLine(binary);
            }
        }
    }
}
