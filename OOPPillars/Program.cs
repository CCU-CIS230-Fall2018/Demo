using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal scooby = new Animal();
            scooby.Name = "Scooby Doo";
            Console.WriteLine(scooby.Name);
        }
    }
}
