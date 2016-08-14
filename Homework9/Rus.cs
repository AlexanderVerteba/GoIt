using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Rus : BaseBot
    {
        public static string Name = "Иван";

        override public void Hello()
        {
            Console.WriteLine("{0}: Привет!", Name);
        }
        override public void Say()
        {
            Console.WriteLine("");
        }
        override public void HowU()
        {
            Console.WriteLine("{0}: Как дела?", Name);
        }
        override public void What()
        {
            Console.WriteLine("{0}: Моя вас не понимать", Name);
        }
        override public void Bye()
        {
            Console.WriteLine("{0}: Удачи!", Name);
        }
    }
}
