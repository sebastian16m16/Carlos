using Carlos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos.Logic
{
    class PersonListManagement
    {
        public List<Person> people { get; set; }
        public List<Team> teams { get; set; }
        public PersonListManagement()
        {
        }

        public PersonListManagement(List<Person> people)
        {
            this.people = people;
        }

        public void AddPerson(Person p)
        {
            this.people.Add(p);
        }

        public List<Person> GenerateTeams(int NrOfTeams)
        {
            List<Person> team = new List<Person>();
            Random r = new Random();

            foreach(Person p in people)
            {
                int random = r.Next(0, NrOfTeams);

                if(teams[random].State == STATE.UNBLOCKED)
                {
                    teams[random].Add(p);
                    teams[random].State = STATE.BLOCKED;
                }
                              
            }

            return team;
        }

        private int isOdd(int NoTeams)
        {
            return people.Count % NoTeams;
        }
    }
}
