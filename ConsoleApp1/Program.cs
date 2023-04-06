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
                    case "Пара": UI.Print(ClassCreator.Para()); break;
                    case "Дисциплина": UI.Print(ClassCreator.Discipline()); break;
                    case "Сотрудник": UI.Print(ClassCreator.Employee()); break;
                    case "Аудитория": UI.Print(ClassCreator.Auditoria()); break;
                    case "Занятие": UI.Print(ClassCreator.Lesson()); break;
                    case "Группа": UI.Print(ClassCreator.Group()); break;
                    case "Смена": UI.Print(ClassCreator.Smena()); break;
                    default: Console.WriteLine("Такой класс не реализован"); break;
                }
            }
        }
    }
}
