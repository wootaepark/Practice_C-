using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7
{
    internal class CharStringBoolean
        
    {
        static void Main(string[] args)
        {
            Char c = 'A';
            String s = "안녕하세요";
            Boolean b = true;
            
            // 위의 경우에서는 닷넷 데이터 형식을 이용함, 위에 System 을 선언해서 그냥 쓸 수 있음 (대문자로 시작)

            Console.WriteLine($"{c}\n{s}\n{b}"); // 보간법 사용
        }
    }
}
