using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExampleA();

            //ExampleB();

            //ExampleC();

            //ExampleD();

            //ExampleE();

            ExampleF();
        }

        static void ExampleA()
        {
            //example to show narrowing conversion error possiblities
            long big = 2147483650; //2147483647 is the largest int
            int normal = (int)big; //implicitly casting a narrowing conversion
            Console.WriteLine(normal); //why do we get a negative number?
        }

        static void ExampleB()
        {
            //example for "is" or "as"

            Person friend = new Person();
            friend.FirstName = "Ross";
            friend.LastName = "Gellar";
            friend.Age = 50; //birthday is October 18, 1967
           
            Student slacker = new Student();
            slacker.FirstName = "Ferris";
            slacker.LastName = "Bueller";
            slacker.Age = 18;
            slacker.Year = 12;

            WorkStudy labAttendant = new WorkStudy();
            labAttendant.FirstName = "Jeremy";
            labAttendant.LastName = "Porier";
            labAttendant.Age = 19;
            labAttendant.Year = 13;
            labAttendant.HourlyRate = 4.25m;

            Console.WriteLine(slacker.FirstName);

            if (slacker is Person)
            {
                Person sp = (Person)slacker;
                Console.WriteLine(sp.FirstName);
            }
       

            Person sp2 = slacker as Person;
            if (sp2 != null)
            {
                Console.WriteLine("the second technique worked as well");

            }
            slacker.StudentID = 7778;
            slacker.FirstName = "Ferris2";
            sp2.FirstName = "Back to Ferris";
            Console.WriteLine(slacker.FirstName);
       

        }

        static void ExampleC()
        {
            //create an array for holding students
            Student[] students = new Student[10];

            //fill the array with student objects
            for (int stuID = 0; stuID < students.Length; stuID++)
            {
                students[stuID] = new Student();
                students[stuID].StudentID = stuID;
            }

            //implicity cast to an array of Persons
            Person[] people = students;

            //this won't work
            //Console.WriteLine(people[1].StudentID);

            //this will still work
            foreach (Student student in students)
            {
                Console.WriteLine(student.StudentID);
            }
        }

        static void ExampleD()
        {
            string answer;
            int qty;
            do
            {
                Console.WriteLine("How many pizzas would you like to order?");
                answer = Console.ReadLine();
            } while (int.TryParse(answer, out qty) == false);

            decimal cost = 11.50m;

            decimal total = qty * cost;

            //string totalString = total.ToString();
            string totalString = (string)Convert.ChangeType(total, typeof(string));
            //string totalString = Convert.ToString(total);

            string message = "At " + cost.ToString() + " per pizza, you owe " + totalString;
            Console.WriteLine(message);
        }

        static void ExampleE()
        {
            string longName = "C:\\Program Files\\Windows Defender Advanced Threat Protection";

            char[] buffer = new char[1024];
            long length = GetShortPathName(longName, buffer, buffer.Length);

            string shortName = new string(buffer);
            Console.WriteLine(shortName.Substring(0, (int)length));
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        static extern uint GetShortPathName(string lpsqLongPath, char[] lpszShortPath, int cchBuffer);

        static void ExampleF()
        {
            string alphabet = String.Empty;

            for (int i = 65; i < 123; i++)
            {
                alphabet = String.Concat(alphabet, (char)i);
            }

            Console.WriteLine(alphabet);

        }
        static void ExampleG()
        {
            int[] myN = new int[3] { 1, 2, 3 };

            foreach (int i in myN)
            {
                Console.WriteLine(i);
            }
        }

        static void ExampleH()
        {
            List<int> myList = new List<int>();

            long x = 43;

            myList.Add(12);
            myList.Add(14);
            myList.Add((int)x);


        }
    }

    
}
