using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Группа
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public static Группа Create()
        {
            return new Группа();
        }
    }
}
