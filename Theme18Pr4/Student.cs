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
        public override int Age()
        {
            int age = DateTime.Now.Year - Dt.Year;
            age = (Dt.Month < DateTime.Now.Month) ? age-- : age;
            return age;
        }
        public override void Output()
        {
            Console.WriteLine($"Имя - {Name}\nФамилия - {Surname}\nДата рождения{Dt}\nФакультет - {Faculty}\nВозраст - {Age()}\nКурс - {Course}");
        }
    }
}
