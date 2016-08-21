using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework11
{
    class Program
    {
        delegate void MyDelegate(string x, int way);

        static MyDelegate del = (string s, int w) =>
        {
            if (w == 1)
            {
                Console.WriteLine("Result: {0}", s);
            }
            else if (w == 2)
            {
                Console.WriteLine("File: C:\\GoIt\\output.txt");
                File.WriteAllText("C:\\GoIt\\output.txt", s);
            }
        };

        static void Main(string[] args)
        {
            String _sOper;
            Int32 _iOper;

            Console.Write("Enter the expression: ");
            _sOper = Console.ReadLine();

            Console.WriteLine("Where i should write it?(Press 1 - console, 2 - file): ");
            Int32 _iWay = Int32.Parse(Console.ReadLine());

            if (Int32.TryParse(_sOper, out _iOper))
            {
                _sOper = (_iOper * _iOper).ToString();
            }

            del(_sOper, _iWay);

            Console.ReadKey();
        }
    }
}
