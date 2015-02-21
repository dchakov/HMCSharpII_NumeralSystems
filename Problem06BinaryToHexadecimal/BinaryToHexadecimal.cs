//Problem 6. binary to hexadecimal• Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter binary number");
        string binaryText = Console.ReadLine();
        int zeroLenght = binaryText.Length % 4;
        if (zeroLenght !=0)
        {
            binaryText = binaryText.PadLeft(binaryText.Length + 4 - zeroLenght, '0'); 
        }
        
        char[] binaryNumber = binaryText.ToCharArray();
        string result = "";
        int counter = 0;
        string currentFour = "";

        for (int i = binaryText.Length - 1; i >= 0; i--)
        {
            if (counter < 4)
            {
                currentFour = (binaryNumber[i] - '0') + currentFour;
                counter++;
            }
            if (counter == 4)
            {
                switch (currentFour)
                {
                    case "0000": result = "0"+ result; break;
                    case "0001": result = "1"+ result; break;
                    case "0010": result = "2"+ result; break;
                    case "0011": result = "3"+ result; break;
                    case "0100": result = "4"+ result; break;
                    case "0101": result = "5"+ result; break;
                    case "0110": result = "6"+ result; break;
                    case "0111": result = "7"+ result; break;
                    case "1000": result = "8"+ result; break;
                    case "1001": result = "9"+ result; break;
                    case "1010": result = "A"+ result; break;
                    case "1011": result = "B"+ result; break;
                    case "1100": result = "C"+ result; break;
                    case "1101": result = "D"+ result; break;
                    case "1110": result = "E"+ result; break;
                    case "1111": result = "F"+ result; break;
                }                            
                counter = 0;
                currentFour = "";
            }
            
        }
        Console.WriteLine(result);
    }
}

