//Problem 3. Decimal to hexadecimal
//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem03DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            // http://www.dreamincode.net/forums/topic/122557-how-to-convert-signed-decimal-to-hex/
            //http://mathforum.org/library/drmath/view/55998.html
            //http://mathforum.org/library/drmath/view/54344.html
            
            
            Console.WriteLine("Please,enter a decimal number [long.MinValue...long.MaxValue]");
            long numberDecimal = long.Parse(Console.ReadLine());


            Console.WriteLine(DecimalToHex(numberDecimal));

        }
        static string DecimalToHex(long decimalNumber)
        {
            bool sign = false;
            if (decimalNumber < 0)
            {
                decimalNumber = decimalNumber ^ long.MinValue;
                sign = true;
            }
            string hex = "";

            while (decimalNumber > 0)
            {

                long digit = decimalNumber % 16;
                if (sign && decimalNumber < 15)
                {
                    digit = digit + 8;
                }

                if (digit >= 0 && digit <= 9)
                {
                    hex = (char)(digit + '0') + hex;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hex = (char)(digit - 10 + 'A') + hex;
                }
                decimalNumber /= 16;
            }
            return hex;
        }
    }
}
