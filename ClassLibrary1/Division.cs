using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Division
    {
        public string Name { get; }
        public Employee Director { get; }
        public Organization Organization { get; }


        public Division(string name, Employee director, Organization organization)
        {
            Name = name;
            Director = director;
            Organization = organization;
        }
    }
}
