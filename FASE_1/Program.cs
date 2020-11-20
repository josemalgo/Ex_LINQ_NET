using System;
using System.Linq;

namespace FASE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15]{ 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            int[] pairs = (from nums in numbers
                          where nums % 2 == 0
                          select nums).ToArray();

            foreach(var pair in pairs)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
