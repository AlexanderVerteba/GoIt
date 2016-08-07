using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while(Menu())
            {
                Console.ReadKey();
                Console.Clear();

            }
        }
        
        static public bool Menu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add scout");
            Console.WriteLine("2. Choose one sport");
            Console.WriteLine("3. Remove one sport");
            Console.WriteLine("4. Show all scouts");
            Console.WriteLine("5. Give an award");
            Console.WriteLine("6. Ratings");
            Console.WriteLine("7. Exit\n");
            Int32 _iChoice =  Int32.Parse(Console.ReadLine());

            Console.Clear();

            switch (_iChoice)
            {
                case 1:
                    {
                        Camp.Add();
                        break;
                    }
                case 2:
                    {
                        Camp.ChooseSport();
                        break;
                    }
                case 3:
                    {
                        Camp.DeleteSport();
                        break;
                    }
                case 4:
                    {
                        Camp.ScoutsList();
                        break;
                    }
                case 5:
                    {
                        Camp.GiveAward();
                        break;
                    }
                case 6:
                    {
                        Camp.Ratings();
                        break;
                    }
                case 7:
                    {
                        return false;
                    }
                default:
                    {
                        Console.WriteLine("Wow!!!");
                        break;
                    }

            }

            return true;
            
        }
    }
}
