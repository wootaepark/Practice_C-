using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class VarInput
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var c = Convert.ToChar(Console.Read()); // .ToChar 없으면 Console.Read()가 정수형으로 자동으로 변환해준다. 
            Console.WriteLine($"{s} : {s.GetType()}, {c} : {c.GetType()}");
            
        }
    }
}
