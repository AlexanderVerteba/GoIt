using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository.PupilsRepository.Add(new Pupil() { Name = "Vasya", Age = 10 });
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add pupil\n2. Add mark\n3. Get average mark\n4. Show all marks\n5. Exit");
                int input;
                int.TryParse(Console.ReadLine(), out input);

                Console.Clear();
                if (input == 1)
                {
                    Repository.AddPupil();                  
                }

                else if (input == 2)
                {
                    Repository.AddMark();
                }

                else if (input == 3)
                {
                    Repository.GetAverageMark();
                    Console.ReadKey();
                }

                else if (input == 4)
                {
                    Repository.GetMarks();
                    Console.ReadKey();
                }
                else if (input == 5)
                {
                    return;
                }
                else Console.WriteLine("Only 1-5!\n");
            }
        }
    }
}
