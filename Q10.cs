using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            int[] original = new int[5];
            int[] copy = new int[5];

            Console.WriteLine("Enter 5 elements for the original array:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Element {i + 1}: ");
                original[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Copy elements
            for (int i = 0; i < 5; i++)
            {
                copy[i] = original[i];
            }

            // Display copied array
            Console.WriteLine("\nElements in the copied array:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(copy[i]);
            }
        }
    }
}