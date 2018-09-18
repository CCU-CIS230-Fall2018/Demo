using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Demo
{
    class Program
    {
       

        static void Main(string[] args)
        {

            LinqOne();

        }

        static void LinqOne()
        {
            List<Student> students = new List<Student>
            {
                new Student("Claire", "Standish", 2, 4),
                new Student("Andrew", "Clark", 3, 3),
                new Student("John", "Bender", 1, 4),
                new Student("Brian", "Johnson", 4, 1),
                new Student("Allison", "Reynolds", 5, 3)
            };

            string[] yearLabels = { "Freshman", "Sophomore", "Junior", "Senior" };

            students.Sort();

            Console.WriteLine(students.First().LastName);

            //var upperclassmen = from s in students where s.Year > 2 select s;
            var upperclassmen = students.Where(s => s.Year > 2 == true);
            foreach (Student s in upperclassmen)
            {
                Console.WriteLine(s.LastName);
            }

        }
    }
}
