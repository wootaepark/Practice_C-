using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class TypeConversionError
    {
        static void Main(string[] args)
        {
            long l = long.MaxValue;
            Console.WriteLine($"l의 값 : {l}");

            int i = (int)l; // 데이터 손실
            Console.WriteLine($"i의 갑 : {i}");
        }
    }
}
