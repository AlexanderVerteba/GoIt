using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    delegate void MyDelegate(Int64 a, Int64 b);

    class Program
    {
        static public event MyDelegate result;

        static void Main(string[] args)
        {
            Console.Write("Enter first operand: ");
            String _sOper1 = Console.ReadLine();
            Console.Write("Enter second operand: ");
            String _sOper2 = Console.ReadLine();

            Console.WriteLine("1: + \n2: - \n3: * \n4: /");
            String _sOps = Console.ReadLine();

            Int64 fOper = Convert.ToInt64(_sOper1);
            Int64 sOper = Convert.ToInt64(_sOper2);

            for (int i = 0; i < _sOps.Length; ++i)
            {
                if (_sOps[i] == '1')
                    result += Operations.Plus;
                else if (_sOps[i] == '2')
                    result += Operations.Minus;
                else if (_sOps[i] == '3')
                    result += Operations.Multiply;
                else if (_sOps[i] == '4')
                    result += Operations.Divide;
            }
            result.Invoke(fOper, sOper);

        }
    }
}
