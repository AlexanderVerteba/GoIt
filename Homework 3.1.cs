using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] login = new string[] { "Superman", "Batman", "Ironman", "Captain_America", "Spiderman", "Flash" };
            String[] password = new string[] { "UFO", "BlackCape", "Captain_America_hater", "Ironman_hater", "Shkolnik2000", "SPEEED" };
            String[] role = new string[] { "Admin", "Admin", "Moderator", "Moderator", "User", "User" };

            Boolean _bFlag = false;
            Int32 _iAttempts = 0;
            String _sName;
            String _sPass;

            while (!_bFlag)
            {
                Console.Write("Enter your superhero login: ");
                _sName = Console.ReadLine();
                Console.Write("Enter your password: ");
                _sPass = Console.ReadLine();

                for (int i = 0; i < login.Length; i++)
                {
                    if (_sName == login[i] && _sPass == password[i])
                    {
                        if (role[i] == "Admin")
                        {
                            Console.WriteLine("\nHello, admin - {0}\n", login[i]);

                            Console.WriteLine("{0, -21} {1, -24} {2, -21}", "Name:", "Password:", "Role:");

                            for (int j = 0; j < login.Length; j++)
                            {
                                Console.WriteLine(String.Format("{0, -21} {1, -24} {2, -21}", login[j], password[j], role[j]));
                            }
                            Console.WriteLine();

                            _bFlag = true;
                        }

                        else if (role[i] == "Moderator")
                        {
                            Console.WriteLine("\nHello, moderator - {0}\n", login[i]);

                            Console.WriteLine("Number of users - {0}", login.Length);

                            _bFlag = true;
                        }

                        else if (role[i] == "User")
                        {
                            Int32 count = 0;

                            Console.WriteLine("\nHello, user - {0}\n", login[i]);

                            Console.WriteLine("Users:");
                            for (int j = 0; j < login.Length; j++)
                            {
                                if (role[j] == "User")
                                {
                                    Console.WriteLine(String.Format("{0, -21}", login[j]));
                                    count++;
                                }
                            }
                            Console.WriteLine("\nNumber of users - {0}", count);

                            _bFlag = true;
                        }
                    }
                }

                if (!_bFlag)
                {
                    _iAttempts++;
                    if (_iAttempts >= 3) { Console.WriteLine("Out of attemps! Try later."); break; }
                    else Console.WriteLine("attempts left: {0}", 3 - _iAttempts);
                }

            }
            Console.ReadKey();
        }
    }
}
