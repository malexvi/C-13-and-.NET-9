using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Person
    {
        public DateTime BirthDate;
        public string Name;
        public string Surname;
        public int Age;

        public Person()
        {
        }

        public Person(string v1, string v2, int v3)
        {
            this.Name = v1;
            this.Surname = v2;
            this.Age = v3;
        }
    }
}
