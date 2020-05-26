using System;
using System.Collections.Generic;

namespace Csharp
{
    public class MainTest
    {
        int length;
        int quizNum;
        int count = 0;
        double scores;
        static void InputLength(int count, int length)
        {
            Console.WriteLine("Eneter the number of quizzes: ");
            length = Convert.ToInt32(Console.ReadLine());
        }
        
        static void InputData(int count, int length, int quizNum, double scores)
        {
            while (count < length)
            {
                Console.Write("Please enter the quiz number: " + "((Q to Quit)) ");
                quizNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter score: ");
                scores = Convert.ToDouble(Console.ReadLine());
                count++;
            }
        }

        static void DisplayPlayerData(int count, int length, int quizNum, int scores)
        {
            Console.WriteLine("Quiz              Score");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0, -15}   {1,-6}", quizNum, scores);
            }
        }

        static void CalculateAverageScore(int count, int length, int quizNum, int scores)
        {
            double total = 0;
            double average = 0;
            for (int i = 0; i < scores; i++)
            {
                total += scores;
            }
            average = total / scores;
            Console.Write("The average score is : " + average);
            if (average >= 90 && average <= 100)
                Console.WriteLine("\nYour average is an A.");
            if (average >= 80 && average <= 89)
                Console.WriteLine("\nYour average is a B.");
            if (average >= 70 && average <= 79)
                Console.WriteLine("\nYour average is a C.");
            if (average >= 60 && average <= 69)
                Console.WriteLine("\nYour average is a D.");
            if (average >= 0 && average <= 59)
                Console.WriteLine("\nYour average is a F.");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string reloop = "N";
            

            do
            {
                Console.WriteLine("To continue press Y");
                reloop = Console.ReadLine();
            }
            while (reloop == "Y" && reloop == "y");

        }
    }
}