using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {       
        public static void Print(Class3 class3)
        {
            Console.WriteLine($"Название дисциплины: {class3.Name}");
            Console.WriteLine($"Сокращение дисциплины: {class3.ShortName}");
        }

    }
}
