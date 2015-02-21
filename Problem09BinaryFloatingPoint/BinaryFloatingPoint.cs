//Problem 9.* Binary floating-point• Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type  float ).
//Example:
//number
//sign
//exponent
//mantissa
//-27,25 1 10000011 10110100000000000000000 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;


class BinaryFloatingPoint
{

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        Console.WriteLine("Please, enter floating point number");
        float floatingN = float.Parse(Console.ReadLine());

        // https://msdn.microsoft.com/en-us/library/de8fssa4(v=vs.110).aspx
        // https://msdn.microsoft.com/en-us/library/System.BitConverter(v=vs.110).aspx
        // https://msdn.microsoft.com/en-us/library/System.BitConverter(v=vs.110).aspx

        byte[] byteArray = BitConverter.GetBytes(floatingN);
        int intValue = BitConverter.ToInt32(byteArray, 0);
        int mask = 1 << 31;
        int nMask = intValue & mask;
        int bit = nMask >> 31;
        

        Console.WriteLine(Convert.ToString(intValue, 2));
        Console.Write("Sign"+" "+"Exponent"+" "+"Mantisa");
        Console.WriteLine();
        Console.Write(Math.Abs(bit)+" ");
        Console.Write(Convert.ToString(intValue, 2).Substring(1, 8)+" ");
        Console.Write(Convert.ToString(intValue, 2).Substring(9));
        Console.WriteLine();

    }

}
