using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNote
{
    internal class UnsignedInteger
    {
        static void Main(string[] args)
        {
            byte iByte = 255;
            ushort iUInt16 = 65535;
            uint iUInt32 = 4294967295;
            ulong iUInt64 = 18446744073709551615;

            Console.WriteLine("8비트 byte : {0}", iByte) ;
            Console.WriteLine("16비트 ushort : {0}", iUInt16) ;
            Console.WriteLine("32비트 uint : {0}", iUInt32) ;
            Console.WriteLine("64비트 ulong : {0}", iUInt64) ;

            Console.WriteLine("uint 32비트 최소 : {0}", uint.MinValue);
            Console.WriteLine("int 32비트 최대 : {0}", int.MaxValue);


            // .MinValue, .MaxValue 를 이용하여 min,max 값을 알 수도 있다.

        }
    }
}
