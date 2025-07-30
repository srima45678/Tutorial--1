using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"\nMaximum element: {max}");
            Console.WriteLine($"Minimum element: {min}");
        }
    }
}
