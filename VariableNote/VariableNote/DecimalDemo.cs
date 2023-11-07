using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNote
{
    internal class DecimalDemo
    {
        static void Main(string[] args)
        {
            decimal d = 12.34M;
            Console.WriteLine("{0}", d);
            Console.WriteLine("십진 소수 최소 : {0}", decimal.MinValue);
            Console.WriteLine("십진 소수 최대 : {0}", decimal.MaxValue);

            double a = 10.0, b = 9.1; // a-b = 0.9

            Console.WriteLine("{0}", a-b);

        }
    }
}
