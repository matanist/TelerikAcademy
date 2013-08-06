﻿//Task9*: Write a program that shows the internal binary representation
//        of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
//        Example: -27,25 → sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;

class FloatToBinary
{
    static void Main()
    {
        Console.Write("Please, enter some floating-point number: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        double number = double.Parse(Console.ReadLine());       // reads the floating-point number
        Console.ResetColor();
        int sign = 0;
        if (number < 0)                                         // is the number negative
        {
            sign = 1;
            number *= -1;                                       // makes the number positive
        }

        int exp = (int)(Math.Floor(Math.Log(number, 2)));       // calculates the exponent

        Console.WriteLine();
        Console.WriteLine("\t┌───────┬────────────────┬───────────────────────────────────┐");
        Console.WriteLine("\t│ Sign  │    Exponent    │             Mantissa              │");
        Console.WriteLine("\t├───────┼────────────────┼───────────────────────────────────┤");
        Console.Write("\t│   ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(sign);                                    // prints the sign
        Console.ResetColor();
        Console.Write("   │    ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Convert.ToString(exp + 127, 2).PadLeft(8, '0'));      // prints the exponent
        Console.ResetColor();
        Console.Write("    │      ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Convert.ToString((int)(Math.Round(number * Math.Pow(2, 23 - exp))) & ~(1 << 23), 2).PadLeft(23, '0'));
        Console.ResetColor();
        Console.WriteLine("      │");
        Console.WriteLine("\t└───────┴────────────────┴───────────────────────────────────┘");
    }
}