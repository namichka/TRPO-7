using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Смена
    {
        public string НазваниеСмены { get; }
        public Смена(string названиеСмены)
        {
            НазваниеСмены = названиеСмены;
        }

        public override string ToString()
        {
            string s = $"Название смены = {this.НазваниеСмены}";
            return s;
        }
        public static Смена Create()
        {
            Console.Write("Укажите название смены: ");

            string названиеСмены = Console.ReadLine();
            return new Смена(названиеСмены); 
        }
    }
}
