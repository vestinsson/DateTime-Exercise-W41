using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Exercise_W41
{
    internal class Person
    {
        public Person(DateTime dt, int id, string name)
        {
            this.dt = dt;
            this.id = id;
            Name = name;
        }

        public string Name {  get; set; }
        public int id { get; set; }
        public DateTime dt { get; set; }

    }
}
