using System;

namespace QT
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopVar = 0;
            do
            {
                Console.WriteLine("Count={0:}", ++loopVar);

            } while (loopVar == 5);
        }
    }
}
