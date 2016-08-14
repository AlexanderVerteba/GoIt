using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    abstract class BaseBot
    {
        String Name { get; set; }

        abstract public void Hello();
        abstract public void Say();
        abstract public void HowU();
        abstract public void What();
        abstract public void Bye();

    }
}
