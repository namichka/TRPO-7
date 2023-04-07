using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public string lastName { get;  }
        public string name { get;  }
        public string surname { get;  }
        public Group group { get;  }
        public DateTime dateOfBirth { get; }
        public Student (string lastName, string name, string surname, Group group, DateTime dateOfBirth)
        {
            this.lastName = lastName; // нужно ли this.
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.dateOfBirth = dateOfBirth;                
        }
    }
}
