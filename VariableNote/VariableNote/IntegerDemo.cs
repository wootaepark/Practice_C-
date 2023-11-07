using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNote
{
    internal class IntegerDemo
    {
        static void Main(string[] args)
        {
            int min =  -2147483648; // 정수형 최소값
            int max = +2147483647; // 정수형 최대값

            Console.WriteLine("int 변수의 최소값 : {0}", min);
            Console.WriteLine("int 변수의 최대값 : {0}", max);

            int under = 1_000_000; // 언더스코어 무시
            Console.WriteLine("{0}",under);
        }
    }
}
