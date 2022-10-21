using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {

                new Student {ID = 123, FirstName = "Joe", Surname = "Bloggs"},
                new Student {ID = 456, FirstName = "Fred", Surname = "Murphy"},
                new Student {ID = 167, FirstName = "Mary", Surname = "Murphy"}
            };


            Console.WriteLine("\n***********Linq Syntax*********\n");
            // Using Linq Syntax
            var murphys =
                from s in students
                where s.Surname == "Murphy"
                select s;

            foreach(Student s in murphys)
            {

                Console.WriteLine(s.FirstName);
            }


            Console.WriteLine("\n***********Lambda Syntax*********\n");
            // Using Lambda Syntax

            murphys = students.Where(s => s.Surname == "Bloggs");
            foreach(Student s in murphys)
            {

                Console.WriteLine(s.FirstName);
            }

            Console.ReadLine();
        }
    }
}
