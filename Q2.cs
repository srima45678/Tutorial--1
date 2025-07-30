using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            //Accepting 5 integers values from the user
            Console.WriteLine("Enter 5 integers values: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Sorting the array in ascending order
            Array.Sort(num);

            // Displaying the sorted array
            Console.WriteLine("\nSorted array in ascending order is: ");
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
        }
    }
}
