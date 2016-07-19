using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 x = 5;
            Int32 y = 12;
            Int32 z = 2;
            Int32 _iResult = (x++ - --y + --x << z++) * (x + y + z);
            /* 
             * 5(x=6) - 11(y=11) + 5(x=5)=-1
             * -1>>2(z=3)=-4
             * -4 * 19(5+11+3)=-76
             */
            Console.WriteLine(_iResult);
        }
    }
}
