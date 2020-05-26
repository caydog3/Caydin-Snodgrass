using System;

namespace Exam_3
{
    class Assignment
    {
        public static void Main(string[] args)
        {
            Average aObj = new Average();

            int[] average = new int[5];
            string control;

            Console.Write("Press any key to continue (enter N to quit program): ");
            control = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the number of assignments: ");
            average[4] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter a student namne: ");
            String name = Console.ReadLine();
            while (control != "N")
            {
                Console.Write("\n{0}'s grade for assignment 1: ", name);
                average[0] = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n{0}'s grade for assignment 2: ", name);
                average[1] = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n{0}'s grade for assignment 3: ", name);
                average[2] = Convert.ToInt32(Console.ReadLine());

                aObj.OutputAverage(average);

                Console.Write("Enter Y to enter another student or N to quit: ");
                control = Convert.ToString(Console.ReadLine());
            }

            while (control == "N")
            {
                for (int i = 0; i < average[4]; i++)
                {
                    Console.WriteLine("{0}'s average grade: {1}", name, average[4]);

                    Console.WriteLine("Assignment 1's average grade: {0}", average[0]);
                    Console.WriteLine("Assignment 2's average grade: {0}", average[1]);
                    Console.WriteLine("Assignment 3's average grade: {0}", average[2]);
                    
                }
                break;
            }
            

            Console.ReadKey();
        }
    }
}
