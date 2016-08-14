using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Eng:BaseBot
    {
        public static string Name = "Bob";

        override public void Hello()
        {
            Console.WriteLine("{0}: Ave!", Name);
        }
        override public void Say()
        {
            Console.WriteLine("");
        }
        override public void HowU()
        {
            Console.WriteLine("{0}: What's up?", Name);
        }
        override public void What()
        {
            Console.WriteLine("{0}: English pls", Name);
        }
        override public void Bye()
        {
            Console.WriteLine("{0}: Cy@!", Name);
        }
    }
}
