using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    class Pupil
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Dictionary<string, int> marks = new Dictionary<string, int>();

        public double Average()
        {
            double sum = 0;
            if (marks.Count == 0)
            {
                Console.WriteLine("There are no marks");
                return 0;
            }
            foreach (var mark in marks)
            {
                sum += mark.Value;
            }
            return sum / marks.Count;
        }
    }
}
