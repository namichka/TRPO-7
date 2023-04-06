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
        public static void Print(ClassA classA)
        {
            Console.WriteLine($"ClassA.Name = {classA.Name}");
            Console.WriteLine($"ClassA.LastName = {classA.LastName}");
        }

        public static void Print(ClassB classB)
        {
            Print(classB.ClassA);
            Print(classB.ClassC);
        }
        public static void Print(ClassC classC)
        {

        }
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
            Print(lesson.VidZanyatia);
        }
        public static void Print(Auditoria Auditoria)
        {
            Console.WriteLine($"Auditoria.Название = {Auditoria.Name}");
            Print(Auditoria.Employee);
            Console.WriteLine($"Auditoria.Количество мест = {Auditoria.NumberMest}");
            Console.WriteLine($"Auditoria.Количество окон = {Auditoria.NumberOkon}");
            Print(Auditoria.Oborydovanie);
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

        public static void Print(Student student)
        {
            Console.WriteLine($"Student Фамилия Студента = {student.Surname}");
            Console.WriteLine($"Student Имя Студента = {student.Name}");
            Console.WriteLine($"Student Отчество Студента = {student.Middlename}");
            Console.WriteLine($"Student Дата Рождения Студента = {student.DateOfBirth}");
            Print(student.Group);
        }
        public static void Print(Class6 class6)
        {
            Console.WriteLine($"Class6.Введите название специальности = {class6.Named}");
            Console.WriteLine($"Class6.Введите сокращение = {class6.Reduction}");
        }

        public static void Print(Class8 Smena)
        {
            Console.WriteLine($"Class6.Введите смену:  = {Smena.Named}");
        }

        public static void Print(Employee employee)
        {
            Console.WriteLine($"Фамилия сотрудника : {employee.Surname}");
            Console.WriteLine($"Имя сотрудника : {employee.Name}");
            Console.WriteLine($"Отчество сотрудника : {employee.Patronymic}");
            Print(employee.Position);
        }

        public static void Print(Class10 class10)
        {
            Console.WriteLine($"Class10.Имя = {class10.Name}");
            Console.WriteLine($"Class10.Оклад = {class10.Salary}");
            Print(class10.Division);

        }

        public static void Print(Division division)
        {
            Console.WriteLine($"Class11.Имя = {division.Name}");
            Print(division.Director);
            Print(division.Organization);
        }

        public static void Print(Class12 class12)
        {
            
            
        }

        public static void Print(Class14 class14)
        {

        }

        public static void Print(Class15 class15)
        {

        }
    }
}
