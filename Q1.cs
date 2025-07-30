using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            { 
              for(int j= 0; j < n; j++)
              {
                if (i == j)
                {
                    Console.WriteLine("Enter the element at index " + i + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                }
            }
        }
    }
}
