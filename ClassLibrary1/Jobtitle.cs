using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public class Jobtitle
     {
     public string Name { get; }
     public string Salary { get; }
     public Division Division { get; }
     
     
     public Jobtitle(string name, string salary, Division division)
     {
         this.Name = name;
         this.Salary = salary;
         this.Division = division;
     }
     }
}
