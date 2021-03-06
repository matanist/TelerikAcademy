﻿//Task 4: Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 → true.

using System;

class ThirdDigitInNumber
{
    static void Main()
    {
        /* Short variant */
        //int n = 1732;
        //bool result = (n / 100) % 10 == 7;

        /* Long variant */
        while (true)
        {
            Console.Write("Enter some integer number (3 or more digits), or type \"end\" to exit: ");
            string str = Console.ReadLine();
            int number = 0;                                                     // type int for integer numbers in range: -2147483648 to 2147483647
            if (int.TryParse(str, out number))                                  // check if the string 'str' is a number
            {
                double length = Math.Floor(Math.Log10(Math.Abs(number)) + 1);   // counts the number of the digits
                int digit = (Math.Abs(number) / 100) % 10;                      // take the value of the 3rd digit
                if (digit > 0)                                                  // if the number has more than 3 digits
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nThe number {0} has {1} digits, and the 3rd digit (right-to-left) is {2}!", number, length, digit);
                    Console.Write("Result: The 3rd digit is 7: ");
                    bool result = digit == 7;                                   // check if the value of the 3rd digit is = 7
                    if (result == true) Console.ForegroundColor = ConsoleColor.Green;
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result + "\n");
                    Console.ResetColor();
                }
                else                                                            // if the number has less than 3 digits
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digits are only {0}!\n", length);
                    Console.ResetColor();
                }
            }
            else                                                                // if the string 'str' is not a number
            {
                if (str == "end") break;                                        // if you want to exit you have to write "end"
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something's wrong!\n");
                Console.ResetColor();
            }
        }
    }
}