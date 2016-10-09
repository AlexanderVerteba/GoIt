using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework context = new Homework();

            #region Menu
            while (true)
            {
                
                Console.Clear();
               
                Console.WriteLine("1. Show products list\n2. Show orders list\n3. Add order\n4. Change Order\n5. Show element by key\n6. Exit");
                int input;
                int.TryParse(Console.ReadLine(), out input);
                Console.Clear();
                if (input == 1)
                {
                    Base.ShowProducts(context);
                    Console.ReadKey();
                }
                else if (input == 2)
                {
                    Base.ShowOrders(context);
                    Console.ReadKey();
                }
                else if (input == 3)
                {
                    Base.AddOrder(context);
                    Console.ReadKey();
                }
                else if (input == 4)
                {
                    Base.ChangeOrder(context);
                    Console.ReadKey();
                }
                else if (input == 5)
                {
                    Base.ShowByKey(context);
                    Console.ReadKey();
                }
                else if (input == 6)
                {
                    break;
                }
                else { Console.WriteLine("Only 1-6!\n"); Console.ReadKey(); }
                }
            #endregion

            Base.ShowProducts(context);
            Base.AddOrder(context);
        }
    }


    static public class Base
    {
        static public void ShowProducts(Homework context)
        {
            var products = context.Products;
            foreach (var item in products)
            {
                Console.WriteLine("{0}: {1}", item.Name, item.Price);
            }
        }

        static public void ShowOrders(Homework context)
        {
            var orders = from ord in context.Orders
                         join prod in context.Products
                         on ord.IdProduct equals prod.IdProduct
                         select new
                         {
                             id = ord.IdOrder,
                             Name = prod.Name,
                             Price = prod.Price,
                             Count = ord.Count
                         };
            foreach (var item in orders)
            {
                Console.WriteLine("(id: {3}){0}: Price: {1}, Count: {4} - {2}", item.Name, item.Price, item.Price*item.Count, item.id, item.Count);
            }
        }

        static public void AddOrder(Homework context)
        {
            Console.WriteLine("Enter product's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter count:");
            int count = Int32.Parse(Console.ReadLine());
            int id = (context.Products.First(n => name == n.Name)).IdProduct;
            context.Orders.Add(new Orders() { IdProduct = id, Count = count});
            context.SaveChanges();
           
        }

        static public void ShowByKey(Homework context)
        {
            Console.WriteLine("Write product's id:");
            int id = Int32.Parse(Console.ReadLine());
            Products p = context.Products.First(n => n.IdProduct == id);
            Console.WriteLine("Id: {0}, Name: {1}, Price: {2}", p.IdProduct, p.Name, p.Price);
        }

        static public void ChangeOrder(Homework context)
        {
            Base.ShowOrders(context);
            Console.WriteLine("Enter product's id:");
            int id = Int32.Parse(Console.ReadLine());
            Console.Clear();
           
            var orders = from ord in context.Orders
                         join prod in context.Products
                         on ord.IdProduct equals prod.IdProduct
                         select new
                         {
                             id = ord.IdOrder,
                             Name = prod.Name,
                             Price = prod.Price,
                             Count = ord.Count
                         };
            foreach (var item in orders)
            {
                if(id == item.id)Console.WriteLine("({3}){0}: {1} - {2}", item.Name, item.Price, item.Price * item.Count, item.id);
            }
            Orders c = (from x in context.Orders
                          where x.IdOrder == id
                          select x).First();
            Console.WriteLine("New count:");
            c.Count= Int32.Parse(Console.ReadLine());
            context.SaveChanges();
        }

    }

}
