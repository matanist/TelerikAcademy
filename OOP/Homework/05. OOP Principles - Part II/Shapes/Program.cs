﻿/* Task 01.
 * Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
 * Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure:
 *      height * width → for rectangle
 *      height * width / 2 → for triangle
 * Define class Circle and suitable constructor so that at initialization height must be kept equal to width
 * and implement the CalculateSurface() method. Write a program that tests the behaviour of the CalculateSurface()
 * method for different shapes (Circle, Rectangle, Triangle) stored in an array.
 */

using System;
namespace Shapes
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Rectangle(34.3, 12.8);
            shapes[1] = new Triangle(7.1, 9.5);
            shapes[2] = new Circle(16.2);

            Console.WriteLine(shapes[0].CalculateSurface());
            Console.WriteLine(shapes[1].CalculateSurface());
            Console.WriteLine(shapes[2].CalculateSurface());
        }
    }
}