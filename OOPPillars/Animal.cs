using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars
{
    class Animal
    {
        private string Title = "Mr.";

        public string Name {
            get { return Title + Name; }
            set { this.Name = value; }
        }
    }
}
