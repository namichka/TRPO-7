using _22ISbo3b;
namespace _22ISbo3b
{
    class Programm
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Какой класс Вы хотите создать: ");
                switch (Console.ReadLine())
                {
                    case "Аудитория": Console.WriteLine(ClassCreator.Аудитория1().ToString()); break;
                    case "Вид занятия": Console.WriteLine(ClassCreator.Вид_Занятия1().ToString()); break;
                    case "Группа": Console.WriteLine(ClassCreator.Группа1().ToString()); break;
                    case "Дисциплина": Console.WriteLine(ClassCreator.Дисциплина1().ToString()); break;
                    case "Занятие": Console.WriteLine(ClassCreator.Занятие1().ToString()); break;
                    case "Пара": Console.WriteLine(ClassCreator.Пара1().ToString()); break;
                    case "Сотрудник": Console.WriteLine(ClassCreator.Сотрудник1().ToString()); break;
                    case "Смена": Console.WriteLine(ClassCreator.Смена1().ToString()); break;
                    default: Console.WriteLine("Такой класс не реализован"); break;
                }
            }
        }
    }
}
