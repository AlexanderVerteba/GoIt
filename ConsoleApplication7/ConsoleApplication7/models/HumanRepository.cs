using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.models
{
    class HumanRepository
    {
        public List<Human> Humans { get; set; }

        public HumanRepository()
        {
            Humans = new List<Human>()
            {
                new Human() {Age = 10, Name="Alex", id = 1 },
                new Human() {Age = 20, Name="Igor", id = 2 },
                new Human() {Age = 105, Name="Nik", id = 3 },
                new Human() {Age = 20, Name="Harold", id = 4 },
                new Human() {Age = 30, Name="Oleg", id = 5 },
                new Human() {Age = 42, Name="Dmitriy", id = 6 },
                new Human() {Age = 13, Name="Ivan", id = 7 }
            };
        }


    }
}
