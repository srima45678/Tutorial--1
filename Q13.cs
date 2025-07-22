using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q13
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            Console.Write(a + " " + b + " ");

            int nextTerm = a + b;

            while (nextTerm <= 100) 
            {
                Console.Write(nextTerm + " ");
                a = b;
                b = nextTerm;
                nextTerm = a + b;
            }
        }
    }
}
