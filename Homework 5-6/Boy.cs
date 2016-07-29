using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_6
{
    class Boy:Scout
    {
        bool [] sports = new bool[3];

        public void ChooseSport()
        {
            Console.WriteLine("Choose sport:");
            Console.WriteLine("1. Basketball");
            Console.WriteLine("2. Volleyball");
            Console.WriteLine("3. Football");
            Int32 _iChoice;
            while (true)
            {
                Int32.TryParse(Console.ReadLine(), out _iChoice);
                if (0 < _iChoice && _iChoice < 4)
                {

                    if (!sports[_iChoice - 1])
                    {
                        sports[_iChoice - 1] = true;
                        Console.WriteLine("Done.");
                       
                        break;
                    }
                    else Console.Write("This kind of sport has been added. Try again: ");
                }
                else Console.Write("Wrong number. Try again: ");
            }
        }

        public void DeleteSport()
        {
            Console.WriteLine("Choose sport:");
            for(int i =0; i<sports.Length; i++)
            {
                if(sports[i])
                {
                    switch (i)
                    {
                        case 0:
                            {
                                Console.WriteLine("1. Basketball");
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("2. Volleyball");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("3. Football");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wow!!!");
                                break;
                            }
                    }
                }
            }
            Int32 _iChoice;
            while (true)
            {
                Int32.TryParse(Console.ReadLine(), out _iChoice);
                if (0 < _iChoice && _iChoice < 4)
                {

                    if (sports[_iChoice - 1])
                    {
                        sports[_iChoice - 1] = false;
                        Console.WriteLine("Done.");
                       
                        break;
                    }
                    else Console.Write("There is no such kind of sport. Try again: ");
                }
                else Console.Write("Wrong number. Try again: ");
            }
        }
    }
}
