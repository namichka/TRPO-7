using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Занятие
    {
        public string Дата_проведения { get; }
        public Сотрудник Сотрудник { get; }
        public Аудитория Аудитория { get; }
        public Группа Группа { get; }
        public Пара Пара { get; }
        public Вид_Занятия Вид_Занятия { get; }
        public Занятие(string дата_проведения, Сотрудник сотрудник, Аудитория аудитория, Группа группа, Пара пара, Вид_Занятия вид_занятия)
        {
            Дата_проведения = дата_проведения;
            Сотрудник = сотрудник;
            Аудитория = аудитория;
            Группа = группа;
            Пара = пара;
            Вид_Занятия = вид_занятия;
        }
        public static Занятие Create()
        {
            Console.Write("Укажите дату проведения: ");
            string дата_проведения = Console.ReadLine();
            Console.Write("Укажите сотрудника: ");
            Сотрудник сотрудник = Сотрудник.Create();
            Console.Write("Укажите аудиторию: ");
            Аудитория аудитория = Аудитория.Create();
            Console.Write("Укажите группу: ");
            Группа группа = Группа.Create();
            Console.Write("Укажите пару: ");
            Пара пара = Пара.Create();
            Console.Write("Укажите вид занятия: ");
            Вид_Занятия вид_занятия = Вид_Занятия.Create();
            return new Занятие(дата_проведения,сотрудник, аудитория, группа, пара, вид_занятия);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
