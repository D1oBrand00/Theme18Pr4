using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr4
{
    class Student : Person
    {
        public int Course { get; set; }
        public Student(string name, string surname, DateTime dt, string faculty, int course) : base(name, surname, dt, faculty)
        { this.Course = course; }
        public override void Output()
        {
            Console.WriteLine($"Студент:\nИмя - {Name}\nФамилия - {Surname}\nДата рождения{Dt}\nФакультет - {Faculty}\nВозраст - {Age()}\nКурс - {Course}\n");
        }
        public static Student Input()
        {
            Console.Write($"Введите имя студента ");
            string name = Console.ReadLine();
            Console.Write($"Введите фамилию студента ");
            string surname = Console.ReadLine();
            Console.Write($"Введите дату рождения ");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Console.Write($"Введите факультет студента ");
            string faculty = Console.ReadLine();
            Console.Write($"Введите курс студента ");
            int course = int.Parse(Console.ReadLine());
            return new Student(name, surname, dt, faculty, course);

        }
    }
}
