using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository aggregate = new Repository();
            Iterator iterator = aggregate.CreateIterator();
            Console.WriteLine("Do you want to load information?(1 - yes, 0 - no)");
            string q = Console.ReadLine();
            if(q=="1") aggregate.Out();

            #region Menu
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add pupil\n2. Add mark\n3. Get average mark\n4. Show all marks\n5. Save\n6. Exit");
                int input;
                int.TryParse(Console.ReadLine(), out input);

                Console.Clear();
                if (input == 1)
                {
                    aggregate.AddPupil();
                }

                else if (input == 2)
                {
                    aggregate.AddMark();
                }

                else if (input == 3)
                {
                    aggregate.GetAverageMark();
                    Console.ReadKey();
                }

                else if (input == 4)
                {
                    aggregate.GetMarks();
                    Console.ReadKey();
                }
                else if (input == 5)
                {
                    aggregate.In();
                    Console.ReadKey();
                }
                else if (input == 6)
                {
                    return;
                }
                else Console.WriteLine("Only 1-6!\n");
            }
            #endregion

        }


        
    }
}
