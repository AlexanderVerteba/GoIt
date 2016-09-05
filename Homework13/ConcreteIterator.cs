using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework12
{
    class ConcreteIterator:Iterator
    {
        private Repository aggregate;

        private int index = -1;

        public ConcreteIterator(Repository aggregateArg)
        {
            this.aggregate = aggregateArg;
        }

        public override object CurrentItem()
        {
            if (index >= 0 && index < aggregate.PupilsRepository.Count)
            {
                return aggregate.PupilsRepository[index];
            }
            return null;

        }

        public override object First()
        {
            if (aggregate.PupilsRepository.Count > 0)
            {
                index = 0;
                return aggregate.PupilsRepository[0];
            }
            return 0;
        }

        public override bool IsDone()
        {
            return index == aggregate.PupilsRepository.Count;
        }

        public override object Next()
        {
            index++;
            if (IsDone()) return 0;
            else return CurrentItem();
        }

      
    }
}
