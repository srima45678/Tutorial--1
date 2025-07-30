using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sorting in descending order
            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("\nArray in descending order: ");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
