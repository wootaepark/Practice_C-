using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class ReadLineCharacter
    {
        static void Main(string[] args)
        {
            Console.Write("문자를 입력하세요 : ");
            string input = Console.ReadLine();
            char c = Convert.ToChar(input);
            // char.Parse(input);
            // Char.Parse(input);
            Console.WriteLine(c) ;
        }
    }
}
