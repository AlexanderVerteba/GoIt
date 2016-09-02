using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.models
{
    class HumanProfessionRep
    {
        public List<HumanProfession> Humanprof { get; set; }

        public HumanProfessionRep()
        {
            Humanprof = new List<HumanProfession>()
            {
                new HumanProfession() { id = 1, Profession = "Writer", Salary=2000},
                new HumanProfession() { id = 2, Profession = "Developer", Salary=20000},
                new HumanProfession() { id = 3, Profession = "Teacher", Salary=1000},
                new HumanProfession() { id = 4, Profession = "Driver", Salary=4000},
                new HumanProfession() { id = 5, Profession = "Doctor", Salary=5000},
            };
        }
    }
}
