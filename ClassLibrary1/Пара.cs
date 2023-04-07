using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Пара
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public static Пара Create()
        {
            return new Пара();
        }
    }
}
