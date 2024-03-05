using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr4
{
    class Enrollee : Person
    {
        public Enrollee(string name, string surname, DateTime dt, string faculty) : base(name, surname, dt, faculty) { }
        public override void Output()
        {
            Console.WriteLine($"Абитуриент: {Name} {Surname}\nДата рождения: {Dt}\nФакультет: {Faculty}\nВозраст: {Age()}");
        }
        public static Enrollee Input()
        {
            Console.Write($"Введите имя абитуриента ");
            string name = Console.ReadLine();
            Console.Write($"Введите фамилию абитуриента ");
            string surname = Console.ReadLine();
            Console.Write($"Введите дату рождения ");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Console.Write($"Введите факультет абитуриента ");
            string faculty = Console.ReadLine();
            return new Enrollee(name, surname, dt, faculty);
        }
    }
}
