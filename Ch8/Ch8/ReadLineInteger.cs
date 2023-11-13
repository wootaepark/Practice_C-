using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class ReadLineInteger
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요 : ");
            string input = Console.ReadLine();  // 문자열 입력
            int number = Convert.ToInt32(input);  // 정수로 형식 변환
            Console.WriteLine($"{number} - {number.GetType()}");
        }
    }
}
