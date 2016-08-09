using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Security:Worker
    {
        public Security()
        {
            Console.Write("Name: ");
            _sName = Console.ReadLine();
            Console.Write("Money per hour: ");
            _iMoneyPerHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of day hours: ");
            _iHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of night hours: ");
            _iHours = 2*Convert.ToInt32(Console.ReadLine());
        }



        public override Decimal GetSalary()
        {
            Decimal _iSum = 0;
            _iSum += _iMoneyPerHour * _iHours;
            return _iSum;
        }

        public override void ExtraHours(Int32 _iExtraHoursArg)
        {
            Int32 Flag;
            while (true)
            {
                Console.Write("It is day(1) or night(2) hours? ");
                Flag = Convert.ToInt32(Console.ReadLine());
                if (Flag == 1) { _iHours += 2 * _iExtraHoursArg; break; }
                else if (Flag == 2) { _iHours += 3 * _iExtraHoursArg; break; }
                else Console.WriteLine("Wrong!");
            }
        }
    }
}
