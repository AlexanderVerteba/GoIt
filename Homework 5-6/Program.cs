using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 _iPoint;
            Int32 _iCount;
            
            Console.Write("Enter your name, please: ");
            String _sVisitor = Console.ReadLine();
            Console.WriteLine("{0}, what do you want to buy?\n", _sVisitor);

            Shop products = new Shop();
            products.ShowProducts();

            while (true)
            {
                Console.Write("\nPoint: ");
                Int32.TryParse(Console.ReadLine(), out _iPoint);
                if (0 < _iPoint && _iPoint <= 5)
                {
                    Console.Write("Count: ");
                    Int32.TryParse(Console.ReadLine(), out _iCount);
                    products.Add(_iPoint, _iCount);
                }
                else if (_iPoint == 7) break;
                else if (_iPoint == 6) products.ShowProducts();
                else Console.WriteLine("Ops! Wrong number, try again:");
            }

            products.Check();
            Console.ReadKey();
        }
    }
}
