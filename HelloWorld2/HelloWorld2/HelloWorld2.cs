using System;
//using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// (.net Framework) 를 사용함

namespace HelloWorld2
{
    internal class HelloWorld2  // internal 을 붙이지 않아도 정상적으로 동작 (.net Core 에서 )
    {
        static void Main(string[] args)
        {
            Console.WriteLine("줄바꿈 있는 HelloWorld");
            Console.Write("줄바꿈 없는 HelloWorld ");
            Console.WriteLine("줄바꿈 있는 HelloWorld");


            

        }
    }
}
