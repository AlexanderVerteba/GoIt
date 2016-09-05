using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework12
{
    class Repository:Aggregate
    {
        public List<Pupil> PupilsRepository=new List<Pupil>();

        private ConcreteIterator Iterator;

        public override Iterator CreateIterator()
        {
            Iterator = new ConcreteIterator(this);
            return Iterator;
        }

        public void AddPupil()
        {
            Console.Write("Name: ");
            String NameArg = Console.ReadLine();
            Int32 AgeArg;
            Console.Write("Age: ");
            Int32.TryParse(Console.ReadLine(), out AgeArg);
            PupilsRepository.Add(new Pupil() { Name = NameArg, Age = AgeArg });
        }

        public void AddMark()
        {
            Int32 Mark;
            String Subject;
            Int32 input;
            bool flag = true;
            for (int i = 0; i < PupilsRepository.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, PupilsRepository[i].Name);
            }

            Console.Write("Choose a pupil: ");
            int.TryParse(Console.ReadLine(), out input);
            while (flag)
            {
                Console.Write("Subject: ");
                Subject = Console.ReadLine();

                Console.Write("Mark: ");
                int.TryParse(Console.ReadLine(), out Mark);

                PupilsRepository[input - 1].marks.Add(Subject, Mark);

                Console.Write("Do you want to add one more?(1-yes, 0-no) ");
                Boolean.TryParse(Console.ReadLine(), out flag);
            }
        }


        public void GetAverageMark()
        {
            Int32 input;
            for (int i = 0; i < PupilsRepository.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, PupilsRepository[i].Name);
            }

            Console.Write("Choose a pupil: ");
            int.TryParse(Console.ReadLine(), out input);
            Console.WriteLine(PupilsRepository[input - 1].Average());
        }

        public void GetMarks()
        {
            Int32 input;

            Console.Write("Enter age: ");
            int.TryParse(Console.ReadLine(), out input);

            foreach (var item in PupilsRepository)
            {
                Console.WriteLine("{0} {1}", item.Name, item.Age);
                foreach (var subject in item.marks)
                {
                    if (item.Age >= input) Console.WriteLine("{0} {1}", subject.Key, subject.Value);
                }
                Console.WriteLine(new string('-', 20));
            }

        }

        public void In()
        {
            FileStream file = new FileStream("C:\\GoIt\\output.txt", FileMode.Truncate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(PupilsRepository.Count);
            foreach (var item in PupilsRepository)
            {
                writer.WriteLine("{0} {1} {2}", item.Name, item.Age, item.marks.Count);
                foreach (var mark in item.marks)
                {
                    writer.WriteLine("{0} {1}", mark.Key, mark.Value);
                }
            }
            writer.Close();
            Console.WriteLine("successfully saved!");
        }

        public void Out()
        {
            FileStream file = new FileStream("C:\\GoIt\\output.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            int n;
            string NameArg;
            int AgeArg;
            string SubjectArg;
            int markArg;
            int k;
            Int32.TryParse(reader.ReadLine().ToString(), out n);
            for (int i = 0; i < n; i++)
            {
                NameArg = reader.Read().ToString();
                AgeArg = reader.Read();
                k = reader.Read();
                reader.ReadLine();
                PupilsRepository.Add(new Pupil() { Name = NameArg, Age = AgeArg });
                for (int j = 0; j < k; j++)
                {
                    SubjectArg = reader.Read().ToString();
                    markArg = reader.Read();
                    reader.ReadLine();
                    PupilsRepository[i].marks.Add(SubjectArg, markArg);
                }
            }

            reader.Close();

        }
    }
}
