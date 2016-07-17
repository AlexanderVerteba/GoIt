using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_3
{
    class Program
    {
        static void Main(string[] args)                                                                
        {
            String[] login = new string[] { "Superman", "Batman", "Ironman", "Captain_America", "Spiderman", "Flash" };
            String[] password = new string[] { "UFO", "BlackCape", "Captain_America_hater", "Ironman_hater", "Shkolnik2000", "SPEEED"} ;
            String[] role  = new string[] { "admin", "admin", "moder", "moder", "user" , "user" } ;

            bool flag = false;
            int attempts = 0;
            string name, pass;
            
            while(!flag)
            {
                Console.Write("Enter your superhero login: ");
                name = Console.ReadLine();
                Console.Write("Enter your password: ");
                pass = Console.ReadLine();

                for(int i=0; i<login.Length; i++)
                {
                    if(name==login[i]&&pass==password[i])
                    {
                        if(role[i]=="admin")
                        {
                            Console.WriteLine("\nHello, admin - {0}\n", login[i]);

                            Console.Write("Name:    ");
                            for(int j=0; j<login.Length; j++)
                            {
                                Console.Write(String.Format("   {0, -21}", login[j]));
                            }
                            Console.WriteLine();

                            Console.Write("Password:");
                            for (int j = 0; j < password.Length; j++)
                            {
                                Console.Write(String.Format("   {0, -21}", password[j]));
                            }
                            Console.WriteLine();

                            Console.Write("Role:    ");
                            for (int j = 0; j < role.Length; j++)
                            {
                                Console.Write(String.Format("   {0, -21}", role[j]));
                            }
                            Console.WriteLine();

                            flag = true;
                        }

                        else if (role[i] == "moder")
                        {
                            Console.WriteLine("\nHello, moderator - {0}\n", login[i]);

                            Console.WriteLine("Number of users - {0}", login.Length);

                            flag = true;
                        }

                        else if (role[i] == "user")
                        {
                            int count = 0;

                            Console.WriteLine("\nHello, user - {0}\n", login[i]);

                            Console.WriteLine("Users:");
                            for (int j = 0; j < login.Length; j++)
                            {
                                if (role[j] == "user")
                                {
                                    Console.WriteLine(String.Format("   {0, -21}", login[j]));
                                    count++;                                    
                                }
                            }
                            Console.WriteLine("Number of users - {0}", count);

                            flag = true;
                        }
                    }
                }                                             

                if (!flag)
                {
                    attempts++;
                    if (attempts >= 3) { Console.WriteLine("Out of attemps! Try later."); break; }
                    else Console.WriteLine("attempts left: {0}", 3 - attempts);
                }

            }
            Console.ReadKey();
        }
    }
}