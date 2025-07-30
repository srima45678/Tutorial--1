using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            //INPUT the no of arrays
            Console.WriteLine("Enter the no of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            //Read elements from the user
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Count Duplicate
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine($"\nTotal number of duplicate elements: {count}");
        }
    }
}