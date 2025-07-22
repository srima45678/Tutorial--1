using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q20
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int number = 1;

            for (int i = 1; i <= rows; i++)
            { 
             Console.Write(new string(' ', rows - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number);
                    number++;
                    if (j < i)
                        Console.Write(" ");
                }
                Console.WriteLine();
                }
            }
        }
    }