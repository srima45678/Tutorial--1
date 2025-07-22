using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string toggle = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                    toggle += char.ToLower(ch);
                else if (char.IsLower(ch))
                    toggle += char.ToUpper(ch);
                else
                    toggle += ch;
            }
            Console.WriteLine("Toggled string: " + toggle);
        }
    }
}
