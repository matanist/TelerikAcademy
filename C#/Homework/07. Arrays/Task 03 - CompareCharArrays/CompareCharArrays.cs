﻿// Task 3. Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter the number of elements in arrays: ");
        char[] arr1 = new char[int.Parse(Console.ReadLine())];
        char[] arr2 = new char[arr1.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            // Reads element from the first char array
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = char.Parse(Console.ReadLine());

            // Reads element from the second char array
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = char.Parse(Console.ReadLine());

            // Compares the elements and print the result
            int sign = arr1[i].CompareTo(arr2[i]);
            Console.WriteLine("{0} {1} {2}\n", arr1[i], (sign > 0) ? ">" : (sign < 0) ? "<" : "=", arr2[i]);
        }
    }
}