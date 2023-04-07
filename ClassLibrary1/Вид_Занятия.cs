using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Вид_Занятия
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public static Вид_Занятия Create()
        {
            return new Вид_Занятия();
        }
    }
}
