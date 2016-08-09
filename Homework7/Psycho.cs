using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Psycho:Worker
    {
        public Int32 _iPatients { get; set; }

        public Psycho()
        {
            Console.Write("Name: ");
            _sName = Console.ReadLine();
            Console.Write("Money per hour: ");
            _iMoneyPerHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of hours: ");
            _iHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of patients: ");
            _iPatients = Convert.ToInt32(Console.ReadLine());
        }



        public override Decimal GetSalary()
        {
            Decimal _iSum = 0;
            _iSum += _iMoneyPerHour * _iHours;
            if (_iPatients > 0)
                _iSum *= _iPatients * 1.2M;
            return _iSum;
        }

        public override void ExtraHours(Int32 _iExtraHoursArg)
        {
            _iHours += _iExtraHoursArg*2;
        }
    }
}
