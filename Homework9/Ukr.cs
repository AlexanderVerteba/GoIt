using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Ukr:BaseBot
    {
        public static string Name = "Богдан";

        override public void Hello()
        {
            Console.WriteLine("{0}: Привiт!", Name);
        }
        override public void Say()
        {
            Console.WriteLine("");
        }
        override public void HowU()
        {
            Console.WriteLine("{0}: Як твої справи?", Name);
        }
        override public void What()
        {
            Console.WriteLine("{0}: Не розумію", Name);
        }
        override public void Bye()
        {
            Console.WriteLine("{0}: Бувай!", Name);
        }
    }
}
