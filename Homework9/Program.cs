using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Program
    {
        static BaseBot bot;
        static String user;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is your name?");
            user = Console.ReadLine();

            Console.Clear();
            bot = Choose();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            bot.Hello();
            bot.HowU();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0}: ", user);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            bot.Bye();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0}: ", user);
            Console.ReadLine();
        }

        static public void Show(int s)
        {
            for(int i =0; i<5; i++)
            {
                if(s==i)Console.ForegroundColor = ConsoleColor.Cyan;
                else Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine((Nation)i);
            }
        }

        static public BaseBot Choose()
        {
            int s = 0;

            System.ConsoleKeyInfo key;
            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("{0}, choose your language(use Up, Down arrows and Enter):", user);
                Show(s);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                    if (s != 4) s++;
                if (key.Key == ConsoleKey.UpArrow)
                    if (s != 0) s--;
                if(key.Key == ConsoleKey.Enter)
                {
                    switch (s)
                    {
                        case (0):
                            return new Ukr();
                        case (1):
                            return new Eng();
                        case (2):
                            return new Fra();
                        case (3):
                            return new Rus();
                        case (4):
                            return new Ger();
                        default:
                            break;
                    }
                }
                Console.Clear();
            }
        }
    }

   

    public enum Nation
    {
        Ukrainian,
        English,
        French,
        Russian,
        German
    }
}
