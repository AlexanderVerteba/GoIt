using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    abstract class Iterator
    {
        public abstract object CurrentItem();
        public abstract object First();
        public abstract bool IsDone();
        public abstract object Next();
    }
}
