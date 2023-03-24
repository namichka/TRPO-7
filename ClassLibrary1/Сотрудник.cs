using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Сотрудник
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public static Сотрудник Create()
        {
            return new Сотрудник();
        }
    }
}
