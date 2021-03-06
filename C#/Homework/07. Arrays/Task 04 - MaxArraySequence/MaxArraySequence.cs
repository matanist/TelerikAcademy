﻿// Task 4. Write a program that finds the maximal sequence of equal elements in an array.
//	       Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} → {2, 2, 2}.

using System;

class MaxArraySequence
{
    static void Main()
    {
        // Reads the number of elements in array
        Console.Write("Enter the number of elements in array: ");
        int[] array = new int[int.Parse(Console.ReadLine())];

        int count = 1;
        int max = 1;
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            // Reads each one element in array
            Console.Write("[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());

            if (i > 0 && array[i] == array[i - 1]) count++;
            else count = 1;
            if (count >= max)
            {
                max = count;
                num = array[i];
            }
        }

        // Prints the result
        Console.Write("The maximal sequence of equal elements in array is: {");
        for (int i = 1; i <= max; i++)
        {
            Console.Write(num);
            if (i < max) Console.Write(", ");
        }
        Console.WriteLine("}");
    }
}