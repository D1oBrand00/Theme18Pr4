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
            while(b)
            {
                Console.WriteLine($"Добавить человека - add");
                    string person = Console.ReadLine();
                bool x = true;
                switch (person)
                {
                    
                    case "add":
                        while(x)
                        {
                            Console.WriteLine("Выберите человека (Абитуриент,Студент,Преподаватель");
                            string man = Console.ReadLine();
                            switch(man.ToLower())
                            {
                                case "абитуриент":
                                    pers.Add(new Enrollee("Леонид", "Войнован", new DateTime(2008, 05, 10), "исскуств"));
                                    
                                    break;
                                case "студент":
                                    pers.Add(new Student("Даниил", "Полозюк", new DateTime(2006, 03, 20), "юридический",2));
                                    break;
                                case "преподаватель":
                                    pers.Add(new Teacher("Сергей", "Зинченко", new DateTime(2000, 01, 23), "информатики","преподаватель", 3));
                                    break;
                                case "q":
                                    x = false;
                                    break;
                            }
                        }
                        x = true;
                        break;
                    case "show":
                        foreach (var elem in pers)
                        {
                            elem.Output();
                        }
                        break;

                }
                b = false;
            }
            
        }
    }
}
