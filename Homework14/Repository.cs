using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Repository
    {
        public List<Item> items;
        public Repository()
        {
            items = new List<Item>()
            {
                new Item(0, "Sprite", 5, 1000, 40),
                new Item(1, "Cola", 10, 100, 2),
                new Item(2, "Pepsi New", 8, 10, 4 ),
                new Item(3, "DrPepper", 25, 20, 0),
                new Item(4, "Mirinda New", 15, 50, 5),
                new Item(5, "Fanta", 10, 50, 5),
            };
        }
    }
}
