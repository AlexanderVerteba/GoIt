using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Fra:BaseBot
    {
        public static string Name = "Antoine";

        override public void Hello()
        {
            Console.WriteLine("{0}: Salut!", Name);
        }
        override public void Say()
        {
            Console.WriteLine("");
        }
        override public void HowU()
        {
            Console.WriteLine("{0}: Comment êtes-vous??", Name);
        }
        override public void What()
        {
            Console.WriteLine("{0}: Je ne comprends pas.", Name);
        }
        override public void Bye()
        {
            Console.WriteLine("{0}: Au revoir!", Name);
        }
    }
}
