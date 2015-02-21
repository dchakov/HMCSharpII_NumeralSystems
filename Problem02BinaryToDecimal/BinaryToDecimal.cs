//Problem 2. Binary to decimal
//Write a program to convert binary numbers to their decimal representation.

// 1010000000000000000010100000000000000000101000000000000000001111
// 1111111111111111111111111111111111111111111111110000000000000011


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem02BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Please, enter binary number");
            string binaryNumber = Console.ReadLine();
            long rezult = 0;

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if ((char)binaryNumber[i] == 49)
                {
                    rezult = rezult + (long)Math.Pow(2, binaryNumber.Length - i - 1);
                }
            }
            Console.WriteLine(rezult);
        }
    }
}
