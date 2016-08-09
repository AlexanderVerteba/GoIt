using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    sealed class InternEmployee:Employee
    {
        public override void ExtraHours(Int32 _iExtraHoursArg)
        {
            _iHours += (Int32)(_iExtraHoursArg * 1.5);
        }
    }
}
