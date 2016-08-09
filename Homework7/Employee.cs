using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Employee:Worker
    {
        public Employee()
        {
            Console.Write("Name: ");
            _sName = Console.ReadLine();
            Console.Write("Money per hour: ");
            _iMoneyPerHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of hours: ");
            _iHours = Convert.ToInt32(Console.ReadLine());
        }



        public override Decimal GetSalary()
        {
            Decimal _iSum = 0;
            _iSum += _iMoneyPerHour * _iHours;
            return _iSum;
        }

        public override void ExtraHours(Int32 _iExtraHoursArg)
        {
            _iHours += _iExtraHoursArg*4;
        }
    }
}
