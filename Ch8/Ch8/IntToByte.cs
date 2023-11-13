using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class IntToByte
    {
        static void Main(string[] args)
        {
            int x = 255;
            byte y = (byte)x;
            Console.WriteLine($"{x} - > {y}");
        }
    }
}
