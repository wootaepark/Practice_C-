using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_C_sharp
{
    internal class Quotes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] \" 이것은 큰따옴표 ☆");
            Console.WriteLine("[2] \' 이것은 작은따옴표");
            Console.WriteLine("[3] ' 이것은 작은따옴표");  // [2], [3]은 동일한 결과
            Console.WriteLine("{0}",3);  // c에서의 %d, %f, %c, %s 느낌
            Console.WriteLine("{0}","Hello, C#"); 
            

            Console.WriteLine("{0}, {1}","Hello, C#","second"); 
            Console.WriteLine("{1}, {0}","Hello, C#","second"); 

            // 위 두 순서는 다르다.
        }
    }
}
