using System;
using System.Linq;

namespace FASE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            var nameO = names.Where(x => x.StartsWith('O'));
            var letters = names.Where(x => x.Count() > 6);
            var nameOrder = names.OrderByDescending(x => x);

            Console.Write("\nNoms que comencen per O: ");
            foreach (var item in nameO)
            {
                Console.Write(item + " ");
            }

            Console.Write("\nNoms que tenen més de sis lletres: ");
            foreach (var item in letters)
            {
                Console.Write(item + " ");
            }

            Console.Write("\nNoms ordenats de manera descendent: ");
            foreach (var item in nameOrder)
            {
                Console.Write(item + " ");
            }
        }
    }
}
