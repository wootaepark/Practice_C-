using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class BinaryString
    {
        static void Main(string[] args)
        {
            byte x = 10;
            byte y = 0B10;

            Console.WriteLine(
                $"십진수 : {x}, 이진수 : {Convert.ToString(x,2).PadLeft(8,'0')}"
                );

            Console.WriteLine(
                $"이진수 : 10, 십진수 : {Convert.ToInt32("10",2)}"
                );

          
    }
}
