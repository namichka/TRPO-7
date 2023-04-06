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
        public static void Print(Para para)
        {
            Console.WriteLine($"Para.Время начала пары = {para.TheStartTimeOfThePair}");
            Console.WriteLine($"Para.Время окончания пары = {para.TheEndTimeOfThePair}");
            Console.WriteLine($"Para.Время начала перерыва = {para.BreakStartTime}");
            Console.WriteLine($"Para.Время окончания перерыва = {para.BreakEndTime}");
        }
        public static void Print(Lesson lesson)
        {
            Console.WriteLine($"Дата проведения занятия = {lesson.Date}");
            Print(lesson.Disciplina);
            Print(lesson.Sotrudnik);
            Print(lesson.Auditoria);
            Print(lesson.Group);
            Print(lesson.Para);

        }
        public static void Print(Auditoria Auditoria)
        {
            Console.WriteLine($"Auditoria.Название = {Auditoria.Name}");
            Print(Auditoria.Employee);
            Console.WriteLine($"Auditoria.Количество мест = {Auditoria.NumberMest}");
            Console.WriteLine($"Auditoria.Количество окон = {Auditoria.NumberOkon}");
        }

        public static void Print(Discipline discipline)
        {
            Console.WriteLine($"Название дисциплины: {discipline.Name}");
            Console.WriteLine($"Сокращение дисциплины: {discipline.ShortName}");
        }

        public static void Print(Group group)
        {
            Console.WriteLine($"Group.Название = {group.Name}");
            Console.WriteLine($"Group.Сокращение = {group.Abbreviation}");
            Console.WriteLine($"Group.Численность = {group.Number}");
            Console.WriteLine($"Group.ГодПоступления = {group.YearOfAdmission}");
            Print(group.HomeroomTeacher);
            Print(group.Speciality);
        }

        public static void Print(Employee employee)
        {
            Console.WriteLine($"Фамилия сотрудника : {employee.Surname}");
            Console.WriteLine($"Имя сотрудника : {employee.Name}");
            Console.WriteLine($"Отчество сотрудника : {employee.Patronymic}");
            Print(employee.Position);
        }

        
        
    }
}
