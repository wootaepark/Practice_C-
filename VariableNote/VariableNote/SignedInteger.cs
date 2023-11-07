using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNote
{
    internal class SignedInteger
    {
        static void Main(string[] args)
        {
            sbyte iSByte = 127;
            short iInt16 = 32767;
            int iInt32 = 2147483647;
            long iInt64 = 9223372036854775807;

            Console.WriteLine("8비트 sbyte : {0}", iSByte);
            Console.WriteLine("16비트 sbyte : {0}", iInt16);
            Console.WriteLine("32비트 sbyte : {0}", iInt32);
            Console.WriteLine("64비트 sbyte : {0}", iInt64);


            // 부호 있는 정수 데이터 형식의 최대 값 출력 
        }
    }
}
