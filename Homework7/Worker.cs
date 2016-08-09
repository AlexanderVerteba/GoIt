using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    abstract class Worker
    {
        public String _sName { get; set; }
        public Decimal _iMoneyPerHour { get; set; }
        public Int32 _iHours { get; set; }
        public Int32 _iExtra { get; set; }

        public abstract Decimal GetSalary();
        public abstract void ExtraHours(Int32 _iExtraHoursArg);
    }
}
