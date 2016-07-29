using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_6
{
    class Scout
    {
        public String _sName { get; set; }
        public Int32 _iGender { get; set; }
        private List<Tuple<string, int>> Awards = new List<Tuple<string, int>>();
        private Int32 _iPointsSum;

        public void GiveAward()
        {
            String _sAward;
            Int32 _iPoints;
            Console.Write("Enter the name of the award: ");
            _sAward = Console.ReadLine();
            Console.Write("Enter number of points(from 0 to 100): ");
            Int32.TryParse(Console.ReadLine(), out _iPoints);

            Tuple<string, int> Award = new Tuple<string, int>(_sAward, _iPoints);
            Awards.Add(Award);
            _iPointsSum += _iPoints;

            Console.WriteLine("Done.");
        }

        public double GetAverageMark()
        {
            if (Awards.Count == 0) return 0;
            else  return _iPointsSum / Awards.Count;
        }

        public int GetSumMark()
        {
            return _iPointsSum;
        }

        public int AwardsNumber()
        {
            
            return Awards.Count;
        }


    }
}
