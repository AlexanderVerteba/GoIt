using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Ger : BaseBot
    {
        public static string Name = "Thomas";

        override public void Hello()
        {
            Console.WriteLine("{0}: Hallo!", Name);
        }
        override public void Say()
        {
            Console.WriteLine("");
        }
        override public void HowU()
        {
            Console.WriteLine("{0}: Wie geht's?", Name);
        }
        override public void What()
        {
            Console.WriteLine("{0}: Ich verstehe nicht.", Name);
        }
        override public void Bye()
        {
            Console.WriteLine("{0}: Auf Wiedersehen!", Name);
        }
    }
}
