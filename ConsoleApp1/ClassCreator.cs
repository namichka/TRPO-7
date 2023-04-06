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
        public static Organization Organization()
        {
            Console.WriteLine("Укажите название организации");
            string name = Console.ReadLine();
            Console.WriteLine("Укажите юридический адрес организации");
            string legal_address = Console.ReadLine();
            Console.WriteLine("Укажите фактический адрес организации");
            string actual_address = Console.ReadLine();


            return new Organization(name, legal_address, actual_address, Employee());
        }
        public static Para Para()
        {
            Console.Write("Укажите время начала пары: ");
            string TheStartTimeOfThePair = Console.ReadLine();
            Console.Write("Укажите время окончания пары: ");
            string TheEndTimeOfThePair = Console.ReadLine();
            Console.Write("Укажите время начала перерыва: ");
            string BreakStartTime = Console.ReadLine();
            Console.Write("Укажите время окончания перерыва: ");
            string BreakEndTime = Console.ReadLine();

            return new Para(TheStartTimeOfThePair, TheEndTimeOfThePair, BreakStartTime, BreakEndTime, Smena());
        }
        public static Lesson Lesson()
        {
            Console.Write("Введите дату проведения: ");
            string date = Console.ReadLine();
            return new Lesson(date, Discipline(), Employee(), Auditoria(), Group(), Para(), Class14());

        }
        public static ClassPara7 ClassPara7()
        {
            return new ClassPara7(DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, new Shift());
        }

        public static Auditoria Auditoria()
        {
            Console.Write("Введите название аудитории: ");
            string aud = Console.ReadLine();
            Console.Write("Введите количество мест: ");
            string mesta = Console.ReadLine();
            Console.Write("Введите количество окон: ");
            string okna = Console.ReadLine();
            return new Auditoria(aud, Employee(), mesta, okna, Class15());
        }


        public static Discipline Discipline()
        {
            Console.Write("Введите дисциплину: ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение дисциплины: ");
            string shortName = Console.ReadLine();
            return new Discipline(name, shortName);
        }



        public static Student Student()
        {
            Console.Write("Введите фамилию студента: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя студента: ");
            string name = Console.ReadLine();
            Console.Write("Введите отчество студента: ");
            string surName = Console.ReadLine();
            Console.Write("Введите дату рождения студента: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            return new Student(lastName, name, surName, Group(), dateOfBirth);
        }

        public static Employee Employee()
        {
            Console.Write("Введите фамилию: ");
            string surnname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string patronymic = Console.ReadLine();
            return new Employee(surnname, name, patronymic, Class10());
        }
        public static Speciality Speciality()
        {
            Console.WriteLine("Введите название специальности");
            string named = Console.ReadLine();
            Console.WriteLine("Введите сокращение");
            string reduction = Console.ReadLine();
            return new Speciality(named, reduction);
        }


        public static Smena Smena()
        {
            Console.WriteLine("Введите название смены: ");
            string name = Console.ReadLine();
            return new Smena(name);
        }

        public static Class10 Class10()
        {
            Console.Write("Введите название: ");
            string name = Console.ReadLine();
            Console.Write("Введите оклад: ");
            string salary = Console.ReadLine();
            return new Class10(name, salary, Division());
        }

        public static Division Division()
        {
            Console.Write("Введите название подразделения: ");
            string name = Console.ReadLine();  


            return new Division(name, Employee(), Class12());
        }

        public static Class12 Class12()
        {
            return new Class12();

        }

        public static Class14 Class14()
        {
            return new Class14();
        }

        public static Class15 Class15()
        {
            return new Class15();
        }

        public static Group Group()
        {
            int yearOfAdmission;
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение: ");
            string abbreviation = Console.ReadLine();
            Console.Write("Введите численность: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите год поступления: ");
            try
            {
                yearOfAdmission = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                yearOfAdmission = DateTime.Now.Year;
            }
            return new Group(name, abbreviation, number, yearOfAdmission, Speciality(), Employee());


        }
    }

    
}
