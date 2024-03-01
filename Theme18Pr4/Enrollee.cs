using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr4
{
    class Enrollee : Person
    {
        public Enrollee(string name, string surname, DateTime dt, string faculty) : base (name,surname,dt,faculty) { }
        public override int Age()
        {
            int age = DateTime.Now.Year - Dt.Year;
            age = (Dt.Month < DateTime.Now.Month) ? age-- : age;
            return age;
        }
        public override void Output()
        {
            Console.WriteLine($"Имя - {Name}\nФамилия - {Surname}\nДата рождения{Dt}\nФакультет - {Faculty}\nВозраст - {Age()}");
        }
    }
}
