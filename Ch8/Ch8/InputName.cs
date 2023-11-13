using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class InputName
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 => ");
            string name = Console.ReadLine();
            Console.WriteLine($"안녕하세요. {name} 님");
        }
    }
}
