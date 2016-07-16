using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoIt_homework_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world!";

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("Char {0}: dec {1}, hex {2};", str[i], Convert.ToString(str[i], 10), Convert.ToString(str[i], 16));
            }

            Console.ReadKey();
        }
    }
}
