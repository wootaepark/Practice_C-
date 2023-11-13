using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9
{
    internal class OperatorRemainder
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 3;
            int k = i % j;

            Console.WriteLine($"i % j = {k}");
        }
    }
}
