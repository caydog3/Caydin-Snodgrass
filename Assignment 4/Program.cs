/* 
 * Programmer: Caydin Snodgrass
 * Date: 2/20/2020
 * Purpose: This program computes the area of a circle, rectangle, and cylinder.
 * Class: CITP 180
 * Assignment #4: Chapter 5 - Programming Excercise 6
 */

using System;

namespace CSAssignment4
{
    class Program
    {
        public static void Main()
        {
            int choice;
            double radius;
            int length;
            int width;
            int tri_base;
            int height;
            double area = 0;

            Console.Write("The geometrical shape area calculator:\n");

            Console.Write("Press 1 for area of circle: \n");
            Console.Write("Press 2 for area of rectangle: \n");
            Console.Write("Press 3 for area of triangle\n");
            Console.Write("Press 1, 2, or 3: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("What is the radius of the circle : ");
                    radius = double.Parse(Console.ReadLine());
                    area = 3.14 * radius * radius;
                    break;
                case 2:
                    Console.Write("What is the length of the rectangle : ");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the width of the rectangle : ");
                    width = Convert.ToInt32(Console.ReadLine());
                    area = length * width;
                    break;
                case 3:
                    Console.Write("What is the base of the triangle :");
                    tri_base = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the hight of the triangle :");
                    height = Convert.ToInt32(Console.ReadLine());
                    area = .5 * tri_base * height;
                    break;
            }
            Console.Write("The area is : {0}\n", area);
        }
    }
}

