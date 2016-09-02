using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication7.models;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //HumanRepository repository = new HumanRepository();
            //HumanProfessionRep repository2 = new HumanProfessionRep();
            //var query = from human in repository.Humans
            //            join humanProf in repository2.Humanprof on human.id equals humanProf.id
            //            where humanProf.Salary < 6000
            //            select new
            //            {
            //                newName = human.Name,
            //                newAge = human.Age,
            //                newProf = humanProf.Profession,
            //                newSalary = humanProf.Salary
            //            };    



            //foreach (var human in query)
            //{
            //    Console.WriteLine(human.newName + " " + human.newSalary);
            //}

            var query = from x in Enumerable.Range(1, 10)
                        from y in Enumerable.Range(1,10)
                        let x1 = x*y
                        group x1 by x into _group
                        select _group;

            foreach (var group in query)
            {
                Console.WriteLine(group.Key);

                foreach (var item in group)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 20));
            }


            Console.ReadKey();
        }
    }

   
}
