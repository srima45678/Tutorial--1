using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            //Ask the user for the size of the array
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            //Declare the array
            int[] arr = new int[n];

            //Read n values into the array
            Console.WriteLine("Enter the values: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Display the values in reverse order
            Console.WriteLine("\nArray in reverse order: ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
