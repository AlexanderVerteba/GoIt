using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {

            Repository products = new Repository();
           
            #region Menu
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Show full list\n2. Show sample\n3. Show list by key words\n4. Exit");
                int input;
                int.TryParse(Console.ReadLine(), out input);
                Console.Clear();
                if (input == 1)
                {
                    Pagination(products);
                }
                else if (input == 2)
                {
                    Example(products);
                }
                else if(input == 3)
                {
                    ByKey(products);
                }
                else if (input == 4)
                {
                    break;
                }
                else Console.WriteLine("Only 1-4!\n");
            }
            #endregion

        }

        static void Pagination(Repository products)
        {
            var query = from beverages in products.items
                        select new{beverages.Name, beverages.Price };
            int page=0;

            int length = (query.Count() + 1) / 2;
            Console.WriteLine("Select page from {0} to {1}", 1, length);
            int input;
            int.TryParse(Console.ReadLine(), out input);
            var pag = query.Skip((input - 1) * 2).Take(2);
            foreach (var item in pag)
            {
                Console.WriteLine("{0} {1}", item.Name, item.Price);
            }
            Console.ReadLine();
        }

        static void ByKey(Repository products)
        {
            Console.WriteLine("Enter key word");
            string key = Console.ReadLine();
            var query = from beverages in products.items
                        where beverages.Name.Contains(key)
                        select new { beverages.Name, beverages.Price };
            foreach (var item in query)
            {
                Console.WriteLine("{0} {1}", item.Name, item.Price);
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void Example(Repository products)
        {
            var query = from beverages in products.items
                        where beverages.Price <= 1000 && beverages.Count > 2 && beverages.Name.Contains("New")
                        select new { beverages.Id, beverages.Summ };
            foreach (var item in query)
            {
                Console.WriteLine("{0} {1}", item.Id, item.Summ);
            }
            Console.ReadKey();
            Console.Clear();
        }

    }
}
