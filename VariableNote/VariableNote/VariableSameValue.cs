using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNote
{
    internal class VariableSameValue
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = b = c = 0;

            Console.WriteLine("{0}, {1}, {1}", a, b, c);


        }
    }
}
