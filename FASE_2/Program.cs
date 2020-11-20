using System;
using System.Linq;

namespace FASE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            Console.WriteLine("Nota mitjana: " + numbers.Average());
            Console.WriteLine("Nota mitjana: " + numbers.Max());
            Console.WriteLine("Nota mitjana: " + numbers.Min());
        }
    }
}
