using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Дисциплина
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public static Дисциплина Create()
        {
            return new Дисциплина();
        }
    }
}
