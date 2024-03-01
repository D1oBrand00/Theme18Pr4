using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr4
{
    abstract class Person
    {
        public string Name { get ; set ; }
        public string Surname { get; set; }
        public DateTime Dt { get; set; }
        public string Faculty { get; set; }
        public Person(string name, string surname, DateTime dt, string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Dt = dt;
            this.Faculty = faculty;
        }
        public abstract int Age();

        public virtual void Output()
        {
            Console.WriteLine($"Имя - {Name}\nФамилия - {Surname}\nДата рождения{Dt}\nФакультет - {Faculty}");
        }

    }
}
