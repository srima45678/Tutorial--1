using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q8
    {
        static void Main()
        {
            // Create array and input values
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Ask for position to delete
            Console.Write("Enter position to delete (1 to 5): ");
            int pos = Convert.ToInt32(Console.ReadLine());

            // Delete the element by shifting
            if (pos < 1 || pos > 5)
            {
                Console.WriteLine("Invalid position!");
            }
            else
            {
                Console.WriteLine("Array after deleting element at position " + pos + ":");
                for (int i = 0; i < 5; i++)
                {
                    if (i == pos - 1)
                        continue; // skip the deleted element
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}