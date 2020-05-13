using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos.Models
{
    class Person
    {
        public static int id { get; set; }
        public string name { get; set; }

        public Person(string name)
        {
            this.name = name;
            id += 1;
        }
    }
}
