using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
    public class Class3
    {
        
        public string Name { get; }
        public string ShortName { get; }
        public Class3(string name, string shortName)
        {
            Name = name;
            ShortName = shortName;
        }
    }
}
