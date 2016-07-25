using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
     public class Shop
    {
        private Product[] list = new Product[5];
        private Int32 [] bought= new Int32 [5];
        private decimal _dSum;

        public Shop ()
        {
            list[0] = new Product("Milk", 1.5M);
            list[1] = new Product("Cola", 1M);
            list[2] = new Product("Apple", 0.5M);
            list[3] = new Product("Meat", 3M);
            list[4] = new Product("Rise", 0.7M);
            _dSum = 0;
        }

        public void ShowProducts()
        {
            Console.WriteLine("----------Products----------");
            for (int i = 0; i < list.Length; ++i)
            {
                Console.WriteLine("{0}. {1, -10} : $ {2}", i + 1, list[i]._sName, list[i]._dPrice);
            }
            Console.WriteLine("\n{0}. Show list again", list.Length + 1);
            Console.WriteLine("{0}. Exit", list.Length + 2);
            Console.WriteLine("----------------------------");
        }

        public void Add(Int32 _iPointArg, Int32 _iCountArg)
        {
            _dSum += list[_iPointArg - 1]._dPrice * _iCountArg;
            bought[_iPointArg - 1] += _iCountArg;
        }

        public void Check()
        {
            Int32 _iDiscount = 0;
            if (_dSum == 0) Console.WriteLine("Seems like your shopping cart is empty. Have a nice day!");
            else
            {
                Console.Write("Do you have a discount?(yes, no) ");
                if (Console.ReadLine() == "yes")
                {
                    Console.Write("\nEnter a value of discount (in percentage): ");
                    Int32.TryParse(Console.ReadLine(), out _iDiscount);
                }
                
                Console.WriteLine("\n---------------Check---------------");
                for (int i = 0; i < list.Length; ++i)
                {
                    if (bought[i] != 0) Console.WriteLine("{0, -10} : $ {1, -3} x {2, 3} = $ {3}", list[i]._sName, list[i]._dPrice, bought[i], bought[i] * list[i]._dPrice);
                }

                if (_iDiscount != 0)
                {
                    Console.WriteLine("\nTotal:                     $ {0}", _dSum);
                    Decimal _dDiscount = _dSum * (100 - _iDiscount) / 100;
                    Console.WriteLine("Discount:                  $ {0}", _dDiscount);
                    Console.WriteLine("For payment:               $ {0}", _dSum - _dDiscount);
                }
                else Console.WriteLine("\nFor payment:               $ {0}", _dSum);
                Console.WriteLine("-----------------------------------");
            }
        }
    }

   
}
