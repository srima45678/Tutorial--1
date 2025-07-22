using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q4
    {
        static void Main(String[] args)
        {
            Console.Write("Enter a number: ");
            string str = Console.ReadLine();
            int x;
            x = Convert.ToInt32(str);
            if (x % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.Read();
        }
    }
}
