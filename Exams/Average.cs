using System;

namespace Exam_3
{
    class Average : Program
    {
        public void OutputAverage(int[] average)
        {
            Console.WriteLine("First grade: " + average[0]);
            Console.WriteLine("Second grade: " + average[1]);
            Console.WriteLine("Third grade: " + average[2]);
            Console.WriteLine("Number of grades: " + average[4]);
            Console.WriteLine("Average grade: " + AverageGrade(average));
        }
    }
}
