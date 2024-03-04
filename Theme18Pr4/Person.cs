using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr4
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Dt { get; set; }
        public string Faculty { get; set; }
        public Person() { }
        public Person(string name, string surname, DateTime dt, string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Dt = dt;
            this.Faculty = faculty;
        }
        public int Age()
        {
            int age = DateTime.Now.Year - Dt.Year;
            return age = (Dt.Month < DateTime.Now.Month) ? age-- : age;
        }

        public abstract void Output();
        

        

    }
}
