using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 _iOperand1;
            Int32 _iOperand2;
            Char _cOper;

            Console.Write("Enter first operand: ");
            _iOperand1 = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                _cOper = Operation();
                Console.Write("Enter second operand: ");
                _iOperand2 = Convert.ToInt32(Console.ReadLine());
                _iOperand1 = Result(_iOperand1, _iOperand2, _cOper);
                Console.WriteLine("Result: {0}",_iOperand1);
            }
        }

        static Char Operation()
        {
            Char _sOper;
            while (true)
            {
                Console.Write("Operation: ");
                _sOper = Convert.ToChar(Console.ReadLine());
                if (_sOper == '+' || _sOper == '-' || _sOper == '*' || _sOper == '/' || _sOper == '%' || _sOper == '^') return _sOper;
                else Console.WriteLine("Wrong operation! Try again.");
            }
        }

        static Int32 Result(Int32 _iOperand1, Int32 _iOperand2, Char _cOper)
        {
            switch (_cOper)
            {
                case '+': return Plus(_iOperand1, _iOperand2);
                case '-': return Minus(_iOperand1, _iOperand2);
                case '*': return Multiply(_iOperand1, _iOperand2);
                case '/': return Share(_iOperand1, _iOperand2);
                case '%': return Remainder(_iOperand1, _iOperand2);
                case '^': return Pow(_iOperand1, _iOperand2);
                default: { Console.WriteLine("It's mistake!"); return _iOperand1; }
            }
        }

        static Int32 Plus(Int32 _iOperand1, Int32 _iOperand2)
        {
            return _iOperand1 + _iOperand2;
        }

        static Int32 Minus(Int32 _iOperand1, Int32 _iOperand2)
        {
            return _iOperand1 - _iOperand2;
        }

        static Int32 Multiply(Int32 _iOperand1, Int32 _iOperand2)
        {
            return _iOperand1 * _iOperand2;
        }

        static Int32 Share(Int32 _iOperand1, Int32 _iOperand2)
        {
            return _iOperand1 / _iOperand2;
        }

        static Int32 Remainder(Int32 _iOperand1, Int32 _iOperand2)
        {
            return _iOperand1 % _iOperand2;
        }

        static Int32 Pow(Int32 _iOperand1, Int32 _iOperand2)
        {
            return (Int32)Math.Pow(_iOperand1, _iOperand2);
        }


    }
}
