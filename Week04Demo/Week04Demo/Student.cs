using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Demo
{
    class Student : Person , IComparable<Student>  //just IComparable for "plain" version
    {
        public int StudentID { get; set; }  //property
        public int Year { get; set; }

        public Student(string firstName, string lastName, int studentID, int year) : base(firstName, lastName)
        {
            StudentID = studentID;
            Year = year;
        }
        /*
        public int CompareTo(Object obj)
        {
            Student other = obj as Student;
            return LastName.CompareTo(other.LastName);
        }
        */

        public int CompareTo(Student other)
        {
            return String.Concat(this.LastName,this.FirstName).CompareTo(String.Concat(other.LastName,other.FirstName));
        }

    }
}
