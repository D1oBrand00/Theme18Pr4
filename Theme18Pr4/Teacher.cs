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
        public Teacher(string name, string surname, DateTime dt, string faculty, string post, int experience) : base (name,surname,dt, faculty)
        {
            this.Post = post;
            this.Experience = experience;
        }
        public override int Age()
        {
            int age = DateTime.Now.Year - Dt.Year;
            age = (Dt.Month < DateTime.Now.Month) ? age-- : age;
            return age;
        }
        public override void Output()
        {
            Console.WriteLine($"Имя - {Name}\nФамилия - {Surname}\nДата рождения{Dt}\nФакультет - {Faculty}\nВозраст - {Age()}\nДолжность - {Post}\nСтаж - {Experience}");
        }
    }
}
