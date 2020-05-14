using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos.Models
{
    class Person
    {
        private static int id { get; set; }
        public int PersonID { get; set; }
        public string name { get; set; }
        public PersonSTATE State { get; set; }

        public Person(string name)
        {
            this.name = name;
            id += 1;
            this.PersonID = id;
            this.State = PersonSTATE.NOT_ALLOCATED;
        }
    }
}
