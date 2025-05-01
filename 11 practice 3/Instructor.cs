using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_practice_3
{
    internal class Instructor
    {
        public Instructor(string name, string office) 
        {
            Name = name;
            OfficeNumber = office;  
        }

        public Instructor()
        {
            Name = "";
            OfficeNumber = "";
        }

        public string Name { get; }
        public string OfficeNumber { get; }

    }
}
