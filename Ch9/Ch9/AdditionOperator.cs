using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9
{
    internal class AdditionOperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello" + "World");
            Console.WriteLine("Hi" + " " + "World");

            Console.WriteLine("123" + "456");
            Console.WriteLine("123" + 456);
            Console.WriteLine(123 + "456"); // 윗줄의 코드와 동일한 결과 "123456"
            Console.WriteLine(123 + 456);
            Console.WriteLine("123" + true);


            // Console.writeLine("123" - 456); 에러 발생 : 문자열 - 정수 는 불가능
        }
    }
}
