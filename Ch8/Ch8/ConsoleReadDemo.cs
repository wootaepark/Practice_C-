using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class ConsoleReadDemo
    {
        static void Main(string[] args)
        {
            int x = Console.Read();
            Console.WriteLine(x);
            Console.WriteLine(Convert.ToChar(x));
        }
    }
}
