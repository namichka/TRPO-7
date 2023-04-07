using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static Class3 Class3()
        {
            Console.Write("Введите название: ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение: ");
            string shortName = Console.ReadLine();
            return new Class3(name, shortName);
        }
    }
}
