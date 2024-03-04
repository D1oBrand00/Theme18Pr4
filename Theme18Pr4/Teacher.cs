using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr4
{
    class Teacher : Person
    {
        public string Post { get; set; }
        public int Experience { get; set; }
        public Teacher(string name, string surname, DateTime dt, string faculty, string post, int experience) : base(name, surname, dt, faculty)
        {
            this.Post = post;
            this.Experience = experience;
        }
        public override void Output()
        {
            Console.WriteLine($"Преподаватель:\nИмя - {Name}\nФамилия - {Surname}\nДата рождения{Dt}\nФакультет - {Faculty}\nВозраст - {Age()}\nДолжность - {Post}\nСтаж - {Experience}");
        }
        public static Teacher Input()
        {
            Console.Write($"Введите имя преподавателя ");
            string name = Console.ReadLine();
            Console.Write($"Введите фамилию преподавателя ");
            string surname = Console.ReadLine();
            Console.Write($"Введите дату рождения ");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Console.Write($"Введите факультет преподавателя ");
            string faculty = Console.ReadLine();
            Console.Write($"Введите должность преподавателя ");
            string post = Console.ReadLine();
            Console.Write($"Введите стаж преподавателя ");
            int experience = int.Parse(Console.ReadLine());
            return new Teacher(name, surname, dt, faculty,post,experience);
        }
    }
}
