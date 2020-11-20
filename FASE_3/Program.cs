using System;
using System.Linq;

namespace FASE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            int[] higher = numbers.Where(x => x > 5).ToArray();
            int[] smaller = numbers.Where(x => x < 5).ToArray();

            Console.Write("Números mayors de 5: ");
            foreach(var high in higher)
            {
                Console.Write(high + " ");
            }

            Console.Write("\nNúmeros menors de 5: ");
            foreach (var small in smaller)
            {
                Console.Write(small + " ");
            }
        }
    }
}
