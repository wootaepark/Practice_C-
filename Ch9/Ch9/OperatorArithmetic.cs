using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9
{
    internal class OperatorArithmetic
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine(
                "{0} % {1} = {2}", a,b,a%b
                );
        }
    }
}
