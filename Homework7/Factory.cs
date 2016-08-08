using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    static class Factory
    {
        private static List<Worker> list = new List<Worker>();

        static public void Menu()
        {
            Console.WriteLine("Welcome!");
            while (true)
            {
                Console.WriteLine("1. Add worker\n2. Add extra hours\n3. Show all\n4. Find worker\n5. Exit");
                string input = Console.ReadLine();
                Console.Clear();
                Int32 _iChoice;
                Int32.TryParse(input, out _iChoice);
                switch (_iChoice)
                {
                    case 1:
                        {
                            Factory.AddWorker();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            if (list.Count != 0)
                            {
                                ShowList();
                                Console.Write("Choose: ");
                                Int32 id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Hours: ");
                                Int32 _iHours = Convert.ToInt32(Console.ReadLine());
                                list[id - 1].ExtraHours(_iHours);
                            }
                            else Console.WriteLine("Ops! List is empty.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            ShowList();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            FindWorker();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Oops");
                            break;
                        }
                }
            }
        }

        static void AddWorker()
        {
            Console.WriteLine("Choose a position:");
            Console.WriteLine("1.Doctor \n2.Psycho \n3.Security \n4.Simple employee \n5.Intern");
            string input = Console.ReadLine();
            int choice;
            Int32.TryParse(input, out choice);
            switch (choice)
            {
                case 1:
                    list.Add(new Doctor());
                    break;
                case 2:
                    list.Add(new Psycho());
                    break;
                case 3:
                    list.Add(new Security());
                    break;
                case 4:
                    list.Add(new Employee());
                    break;
                case 5:
                    Console.WriteLine("IN DEVELOPING!");
                    //list.Add(new Intern());
                    break;
                default:
                    break;
            }
        }

        static void ShowList()
        {
            if (list.Count != 0)
            {
                int i = 0;
                foreach (var w in list)
                {
                    i++;
                    Console.WriteLine("{0}. {1}", i, w._sName);
                }
            }
            else Console.WriteLine("Ops! List is empty.");
        }

        static void FindWorker()
        {
            Console.Write("Enter worker's name: ");
            String name = Console.ReadLine();
            Console.WriteLine();
            int i = 0;
            foreach (var w in list)
            {
                if (w._sName == name)
                {
                    Console.WriteLine("Name: {0}", w._sName);

                    Console.Write("Position: ");
                    if (w is Doctor) Console.WriteLine("Doctor");
                    else if (w is Psycho) Console.WriteLine("Psycho");
                    else if (w is Security) Console.WriteLine("Security");
                    else if (w is Employee) Console.WriteLine("Employee");
                    else if (w is Intern) Console.WriteLine("Intern");

                    Console.WriteLine("Salary: {0}", w.GetSalary());
                    i++;
                }
            }
            if (i == 0) Console.WriteLine("There is no worker with that name.");
        }
    }
}
