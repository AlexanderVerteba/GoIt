using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_6
{
    static class Camp
    {
        static List<Scout> scouts = new List<Scout>();

        static public void Inz()
        {
            scouts.Add(new Boy { _sName = "Superman", _iGender = 1 });
            scouts.Add(new Boy { _sName = "Batman", _iGender = 1 });
            scouts.Add(new Boy { _sName = "Deadpool", _iGender = 1 });
            scouts.Add(new Girl { _sName = "Black Widow", _iGender = 2 });
            scouts.Add(new Girl { _sName = "Mystic", _iGender = 2 });
            scouts.Add(new Girl { _sName = "Catwoman", _iGender = 2 });


        }

        static public void Add()
        {
            String _sNameIn;
            Int32 _iGenderIn;

            Console.Write("Enter scout's name: ");
            _sNameIn = Console.ReadLine();
            Console.Write("Enter scout's gender (1-male, 2-female): ");
            Int32.TryParse(Console.ReadLine(), out _iGenderIn);
            while (true)
            {
                if (_iGenderIn == 1) { scouts.Add(new Boy { _sName = _sNameIn, _iGender = _iGenderIn }); break; }
                else if (_iGenderIn == 2) { scouts.Add(new Girl { _sName = _sNameIn, _iGender = _iGenderIn }); break; }
                Console.Write("Ops!!! Enter scout's gender (1-male, 2-female): ");
                Int32.TryParse(Console.ReadLine(), out _iGenderIn);
            }
        

            Console.WriteLine("Done.");
        }

        static public void ChooseSport()
        {
            Console.WriteLine("Choose scout:");
            Camp.ScoutsList();
            Int32 i = Int32.Parse(Console.ReadLine());
            if(scouts[i-1]._iGender == 1) ((Boy)scouts[i-1]).ChooseSport();
            else ((Girl)scouts[i-1]).ChooseSport();
        }

        static public void DeleteSport()
        {
            Console.WriteLine("Choose scout:");
            Camp.ScoutsList();
            Int32 i = Int32.Parse(Console.ReadLine());
            if (scouts[i-1]._iGender == 1) ((Boy)scouts[i-1]).DeleteSport();
            else ((Girl)scouts[i-1]).DeleteSport();
        }

        static public void GiveAward()
        {
            Console.WriteLine("Choose scout:");
            Camp.ScoutsList();
            Int32 i = Int32.Parse(Console.ReadLine());
            scouts[i-1].GiveAward();
        }

        static public double CampAverageMark()
        {
            int sum=0;
            int i = 0;
            for (; i<scouts.Count; i++)
            {
                sum += scouts[i].GetSumMark();
            }

            return sum / i;

        }

        static public double ScoutAverageMark()
        {
            Console.WriteLine("Choose scout:");
            Camp.ScoutsList();
            Int32 i = Int32.Parse(Console.ReadLine());
            return scouts[i-1].GetAverageMark();
        }

        static public Scout GreatestAverageMark(Int32 _iGenderArg)
        {
            int s=0;

            for (int i = 0; i < scouts.Count; i++)
            {
                if (scouts[i]._iGender == _iGenderArg) { s = i; break; }
            }

            for (int i=0; i<scouts.Count; ++i)
            {
                if (scouts[i]._iGender == _iGenderArg && scouts[i].GetAverageMark() > scouts[s].GetAverageMark()) s = i;
            }
            return scouts[s];
        }

        static public Scout GreatestSummaryMark(Int32 _iGenderArg)
        {
            int s = 0;

            for (int i = 0; i < scouts.Count; i++)
            {
                if (scouts[i]._iGender == _iGenderArg) { s = i; break; }
            }

            for (int i = 0; i < scouts.Count; i++)
            {
                if (scouts[i]._iGender == _iGenderArg && scouts[i].GetSumMark() > scouts[s].GetSumMark()) s = i;
            }
            return scouts[s];
        }

        static public Scout BiggestNumberofAwards(Int32 _iGenderArg)
        {
            int s = 0;

            for (int i = 0; i < scouts.Count; i++)
            {
                if (scouts[i]._iGender == _iGenderArg) { s = i; break; }
            }

            for (int i = 0; i < scouts.Count; i++)
            {
                if (scouts[i]._iGender == _iGenderArg && scouts[i].AwardsNumber() > scouts[s].AwardsNumber()) s = i;
            }
            return scouts[s];
        }

        static public Scout LeastNumberofAwards(Int32 _iGenderArg)
        {
            int s = 0;

            for (int i = 0; i < scouts.Count; i++)
            {
                if (scouts[i]._iGender == _iGenderArg) { s = i; break; }
            }

            for (int i = 0; i < scouts.Count; i++)
            {
                if (scouts[i]._iGender == _iGenderArg && scouts[i].AwardsNumber() < scouts[s].AwardsNumber()) s = i;
            }
            return scouts[s];
        }

        static public void Ratings()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("What do you want to check?");
                Console.WriteLine("1. Camp average mark");
                Console.WriteLine("2. Scout's average mark");
                Console.WriteLine("3. Scout with the greatest average mark");
                Console.WriteLine("4. Scout with the greatest summary mark");
                Console.WriteLine("5. Scout with the biggest number of awards");
                Console.WriteLine("6. The lamest one");
                Console.WriteLine("7. Back.");

                Int32 _iChoice;

                _iChoice = Int32.Parse(Console.ReadLine());

                switch (_iChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("Average camp mark: {0}", Camp.CampAverageMark());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Scout average mark: {0}", Camp.ScoutAverageMark());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Boy with biggest average mark:\n{0}: {1}", Camp.GreatestAverageMark(1)._sName, Camp.GreatestAverageMark(1).GetAverageMark());
                            Console.WriteLine("Girl with biggest average mark:\n{0}: {1}", Camp.GreatestAverageMark(2)._sName, Camp.GreatestAverageMark(2).GetAverageMark());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Boy with biggest summary mark:\n{0}: {1}", Camp.GreatestSummaryMark(1)._sName, Camp.GreatestSummaryMark(1).GetSumMark());
                            Console.WriteLine("Girl with biggest summary mark:\n{0}: {1}", Camp.GreatestSummaryMark(2)._sName, Camp.GreatestSummaryMark(2).GetSumMark());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Boy with biggest number of awards:\n{0}: {1}", Camp.BiggestNumberofAwards(1)._sName, Camp.BiggestNumberofAwards(1).AwardsNumber());
                            Console.WriteLine("Girl with biggest number of awards:\n{0}: {1}", Camp.BiggestNumberofAwards(2)._sName, Camp.BiggestNumberofAwards(2).AwardsNumber());
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Boy with least number of awards:\n{0}: {1}", Camp.LeastNumberofAwards(1)._sName, Camp.LeastNumberofAwards(1).AwardsNumber());
                            Console.WriteLine("Girl with least number of awards:\n{0}: {1}", Camp.LeastNumberofAwards(2)._sName, Camp.LeastNumberofAwards(2).AwardsNumber());
                            break;
                        }
                    case 7:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wow!!!");
                            break;
                        }

                }
                if(flag)
                {
                    Console.ReadKey();
                    Console.Clear();
                }
               
            }
        }


        static public void ScoutsList()
        {
            Int32 i = 0;
            foreach (var scout in scouts)
            {
                if (scout._iGender == 1) Console.WriteLine("{0}. {1} (М)", ++i, scout._sName);
                else Console.WriteLine("{0}. {1} (F)", ++i, scout._sName);
            }
        }

    }
}
