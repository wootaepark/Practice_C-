using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7
{
    internal class MultiLineString
    {
        static void Main(string[] args)
        {
            string multiLines = @"
                    안녕하세요
                    반갑습니다.";  // sql 쓸때 편할 수 있다.

            Console.WriteLine(multiLines);
        }
    }
}
