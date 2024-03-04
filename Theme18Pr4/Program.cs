using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во персон");
            int n = int.Parse(Console.ReadLine());
            List<Person> pers = new List<Person>();
            bool b = true;
            while (b)
            {
                Console.WriteLine($"Добавить человека - add,show - показать список,search - поиск людей в возрасте от диапозона,q - выйти");
                string person = Console.ReadLine();
                int x = 0; ;
                switch (person)
                {

                    case "add":
                        Console.WriteLine();
                        while (x < n)
                        {
                            Console.WriteLine("Выберите человека (Абитуриент,Студент,Преподаватель)");
                            string man = Console.ReadLine();
                            switch (man.ToLower())
                            {
                                case "абитуриент":
                                    pers.Add(Enrollee.Input());
                                    x++;

                                    break;
                                case "студент":
                                    pers.Add(Student.Input());
                                    x++;
                                    Console.WriteLine();
                                    break;
                                case "преподаватель":
                                    pers.Add(Teacher.Input());
                                    x++;
                                    break;
                                case "q":

                                    break;
                            }
                        }
                        break;
                    case "show":
                        Console.WriteLine();
                        foreach (var elem in pers)
                        {
                            elem.Output();
                        }
                        break;
                    case "search":
                        Console.WriteLine();
                        Console.WriteLine("Введите начало диапозона возраста");
                        int begin = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите конец диапозона возраста");
                        int end = int.Parse(Console.ReadLine());
                        Console.Write($"Люди в возросте с диапозоно от {begin} до {end}\n");
                        foreach (var elem in pers)
                        {
                            if (elem.Age() >= begin && elem.Age() <= end)
                            {
                                elem.Output();
                            }
                        }
                        break;
                    case "q":
                        b = false;
                        break;
                    default:
                        Console.WriteLine("Я не знаю такой команды :<");
                        break;

                }
            }

        }
    }
}
