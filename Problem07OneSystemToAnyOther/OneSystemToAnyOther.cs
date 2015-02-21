//Problem 7. One system to any other• Write a program to convert from any numeral system of given base  s  to any other numeral system of base  d  (2 ≤  s ,  d  ≤ 16).

using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.WriteLine("Please,enter base s for system");
        byte baseS = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter number of any numeral system");
        string numberOneSystem = Console.ReadLine();

        Console.WriteLine("Convertion to decimal");
        Console.WriteLine(BaseToDecimal(numberOneSystem, baseS));

        Console.WriteLine("Please,enter base d for other numeral system");
        byte baseD = byte.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(OtherSystem(BaseToDecimal(numberOneSystem, baseS), baseD));
    }
    static string OtherSystem(long decimalNumber, int numeralBase)
    {
        string result = "";

        while (decimalNumber > 0)
        {
            long digit = decimalNumber % numeralBase;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else if (digit >= 10 && digit <= 15)
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            decimalNumber /= numeralBase;
        }
        return result;
    }
    static long BaseToDecimal(string number,int numeralSystem)
    {
        long decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;
            if (number[i] >='0' && number[i]<='9')
            {
                digit = number[i] - '0';
            }
            else if (number[i] >= 'A' && number[i] <= 'F')
            {
                digit = number[i] - 'A' + 10;
            }
            decimalNumber += digit * (long)Math.Pow(numeralSystem, number.Length - i - 1);
        }
        return decimalNumber;
    }
}