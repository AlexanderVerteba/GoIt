using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Doctor:Worker
    {
        public Int32 _iHealed { get; set; }
        public Decimal _iBonusPerHealed { get; set; }

        public Doctor()
        {
            Console.Write("Name: ");
            _sName = Console.ReadLine();
            Console.Write("Money per hour: ");
            _iMoneyPerHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of hours: ");
            _iHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("People healed: ");
            _iHealed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bonus per healed: ");
            _iBonusPerHealed = Convert.ToInt32(Console.ReadLine());
        }



        public override Decimal GetSalary()
        {
            Decimal _iSum =0;
            _iSum += _iMoneyPerHour * _iHours;
            _iSum += _iBonusPerHealed * _iHealed;
            return _iSum;
        }

        public override void ExtraHours(Int32 _iExtraHoursArg)
        {
            _iHours += _iExtraHoursArg;
        }
    }
}
