using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Какой класс Вы хотите создать: ");
                switch (Console.ReadLine())
                {                   
                    case "Скоращ. Дисциплины": UI.Print(ClassCreator.Class3()); break;                   
                    default: Console.WriteLine("Такой класс не реализован"); break;
                }
            }
        }
    }
}
