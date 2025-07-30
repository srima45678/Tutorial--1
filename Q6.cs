using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter the number of elements: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[n];
                int[] even = new int[n];
                int[] odd = new int[n];
                int evenCount = 0, oddCount = 0;

                Console.WriteLine("Enter the elements:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());

                    if (arr[i] % 2 == 0)
                    {
                        even[evenCount] = arr[i];
                        evenCount++;
                    }
                    else
                    {
                        odd[oddCount] = arr[i];
                        oddCount++;
                    }
                }

                // Display even numbers
                Console.WriteLine("\nEven elements:");
                for (int i = 0; i < evenCount; i++)
                {
                    Console.WriteLine(even[i]);
                }

                // Display odd numbers
                Console.WriteLine("\nOdd elements:");
                for (int i = 0; i < oddCount; i++)
                {
                    Console.WriteLine(odd[i]);
                }
            }
        }
    }
}