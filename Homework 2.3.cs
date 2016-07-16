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
            int x = 5, y = 12, z = 2;
            int result = (x++ - --y + --x << z++) * (x + y + z);
            /* 
             * 5 - 11 + 5=-1
             * -1>>2=-4
             * -4 * 19=-76
             */
            Console.WriteLine(result);
        }
    }
}