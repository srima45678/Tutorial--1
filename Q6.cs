using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            string str;

            Console.Write("Enter Number 1 : ");
            str = Console.ReadLine();

            //Missing statement

            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2 : ");

            //Missing statement
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3 : ");

            str = Console.ReadLine();
            c = Convert.ToInt32(str);
            //Missing statement

            result = Sum(a, b, c);

            //Missing statement
            Console.WriteLine("Sum : {0}", result);
            Console.Read();
        }
        static int Sum(int x, int y, int z)

        {
            int res;
            res = x + y + z;
            return res;

        }
    }
}
