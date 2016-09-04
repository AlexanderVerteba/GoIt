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
            Console.WriteLine("Do you want to load information?(1 - yes, 0 - no)");
            string q = Console.ReadLine();
            if(q=="1") Repository.Out();
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add pupil\n2. Add mark\n3. Get average mark\n4. Show all marks\n5. Save\n6. Exit");
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
                    Repository.In();
                    Console.ReadKey();
                }
                else if (input == 6)
                {
                    return;
                }
                else Console.WriteLine("Only 1-6!\n");
            }
        }
    }
}
