using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Demo
{
    class Person
    {
    
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; } //property allows accessors
        //public string firstName; // p67 a field stores characterstic data for a class

        public string LastName { get; set; }
        public short Age { get; set; }
    }
}
