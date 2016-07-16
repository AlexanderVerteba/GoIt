using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoIt_homework_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, a, b, c;
            
            Console.WriteLine("Circle:");
            Console.Write("Radius = ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S = {0}\n", Math.Pow(r,2) * Math.PI);

            Console.WriteLine("Sphere:");
            Console.Write("Radius = ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("V = {0}", 4 / 3 * Math.Pow(r,3) * Math.PI);

            Console.WriteLine("\nRectangle:");
            Console.Write("Length = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S = {0}", a * b);

            Console.WriteLine("\nCuboid:");
            Console.Write("Length = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height = ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("V = {0}", a * b * c);

            Console.ReadKey();
        }
    }
}