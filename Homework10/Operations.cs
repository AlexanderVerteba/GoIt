using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class Operations
    {
        public static void Plus(Int64 _iFirst, Int64 _iSecond)
        {
            Console.WriteLine("Result (+): {0}", _iFirst + _iSecond);
        }

        public static void Minus(Int64 _iFirst, Int64 _iSecond)
        {
            Console.WriteLine("Result (-): {0}", _iFirst - _iSecond);
        }

        public static void Multiply(Int64 _iFirst, Int64 _iSecond)
        {
            Console.WriteLine("Result (*): {0}", _iFirst * _iSecond);
        }

        public static void Divide(Int64 _iFirst, Int64 _iSecond)
        {
            if(_iSecond != 0) Console.WriteLine("Result (/): {0}", _iFirst / _iSecond);
            else Console.WriteLine("Ops! Second operand = 0.");
        }
    }
}
