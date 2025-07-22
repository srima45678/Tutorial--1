using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                Console.Write(new string(' ', rows - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    if (j < i)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
