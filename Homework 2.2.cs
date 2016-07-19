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
            Int32 _iRadius;
            Int32 _iA;
            Int32 _iB;
            Int32 _iC;

            Console.WriteLine("Circle:");
            Console.Write("Radius = ");
            _iRadius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S = {0}\n", Math.Pow(_iRadius, 2) * Math.PI);

            Console.WriteLine("Sphere:");
            Console.Write("Radius = ");
            _iRadius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("V = {0}", 4 / 3 * Math.Pow(_iRadius, 3) * Math.PI);

            Console.WriteLine("\nRectangle:");
            Console.Write("Length = ");
            _iA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width = ");
            _iB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S = {0}", _iA * _iB);

            Console.WriteLine("\nCuboid:");
            Console.Write("Length = ");
            _iA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width = ");
            _iB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height = ");
            _iC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("V = {0}", _iA * _iB * _iC);

            Console.ReadKey();
        }
    }
}
