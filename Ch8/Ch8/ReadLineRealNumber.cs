using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    internal class ReadLineRealNumber
    {
        static void Main(string[] args)
        {
            Console.Write("실수를 입력하세요 : ");
            string input = Console.ReadLine();
            double PI = Convert.ToDouble(input);
            // == double.Parse(input);
            // == Double.Parse(input);
            Console.WriteLine(PI);


        }
    }
}
