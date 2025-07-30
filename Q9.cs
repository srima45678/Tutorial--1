using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1.Tutorial___2
{
    internal class Q9
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2]; // First matrix
            int[,] b = new int[2, 2]; // Second matrix
            int[,] sum = new int[2, 2]; // Result matrix

            Console.WriteLine("Enter elements of first 2x2 matrix:");
            for (int i = 0; i < 2; i++) // rows
            {
                for (int j = 0; j < 2; j++) // columns
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of second 2x2 matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"b[{i},{j}] = ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Adding both matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }

            // Display the result
            Console.WriteLine("\nSum of the two matrices:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}