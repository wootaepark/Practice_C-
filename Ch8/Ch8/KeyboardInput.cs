using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class KeyboardInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("아무키나 누르세요");
            ConsoleKeyInfo cki = Console.ReadKey(true); // 키보드 키 값 입력
            Console.WriteLine("{0}", cki.Key); // 키
            Console.WriteLine("{0}", cki.KeyChar); // 유니코드
            Console.WriteLine("{0}", cki.Modifiers); // Ctrl , Shift, Alt 조합
            if(cki.Key == ConsoleKey.Q)
            {
                Console.WriteLine("Q를 입력하셨습니다...");
            }

        }
    }
}
