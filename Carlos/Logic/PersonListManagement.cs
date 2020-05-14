using Carlos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carlos.Logic
{
    class PersonListManagement
    {
        public List<Person> people { get; set; }
        public List<Team> teams { get; set; }
        private int columnCount { get; set; }
        public PersonListManagement()
        {
            people = new List<Person>();
            teams = new List<Team>();
        }

        public PersonListManagement(List<Person> people)
        {
            this.people = people;
            teams = new List<Team>();
        }

        public void AddPerson(Person p)
        {
            this.people.Add(p);
        }

        public List<Team> GenerateTeams(int NrOfTeams)
        {
            List<Person> team = new List<Person>();
            Random r = new Random();

            //
            // Create the teams
            //
            for(int i=0; i<NrOfTeams; i++)
            {
                teams.Add(new Team());
            }

            int counter = 0;
            int random = 0;

            foreach (Person p in Shuffle(people))
            {
               
                
                random = r.Next(0, NrOfTeams-1);
                
                if (teams[random].State == STATE.UNBLOCKED)
                {
                    teams[random].Add(p);
                    teams[random].State = STATE.BLOCKED;

                    counter++;

                }
                else
                {
                    while (teams[random].State == STATE.BLOCKED)
                    {
                        random = r.Next(0, NrOfTeams-1);

                        if (teams[random].State == STATE.UNBLOCKED)
                        {
                            teams[random].Add(p);
                            teams[random].State = STATE.BLOCKED;

                            counter++;
                            break;
                        }

                        if(counter == NrOfTeams - 1)
                        {
                            for(int i=0; i<NrOfTeams; i++)
                            {
                                if (teams[i].State == STATE.UNBLOCKED)
                                {
                                    teams[i].Add(p);
                                    teams[i].State = STATE.BLOCKED;
                                    
                                    counter++;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }

                if (counter == NrOfTeams)
                {
                    foreach (Team t in teams)
                    {
                        t.State = STATE.UNBLOCKED;
                    }
                    counter = 0;
                }
            }
            columnCount = NrOfTeams;
            return teams;
        }

        private bool isOdd(int NoTeams)
        {
            return (people.Count % NoTeams) != 0;
        }

        private int LargestTeam(int NoTeams)
        {
            int max = 0;

            if (isOdd(NoTeams))
            {
                max = people.Count / NoTeams + 1;
            }
            else
            {
                max = people.Count / NoTeams;
            }

            return max;
        }

        public void LoadTable(DataGridView dataGridView)
        {
            dataGridView.ColumnCount = columnCount;
            dataGridView.RowCount = LargestTeam(teams.Count);
            int row = 0;

            foreach(Team t in teams)
            {
                dataGridView.Columns[t.TeamID-1].Name = t.TeamID.ToString();
                
                foreach(Person p in t)
                {
                    dataGridView.Rows[row++].Cells[t.TeamID - 1].Value = p.name;
                }
                row = 0;
            }
        }

        public void REMOVE_ALL()
        {
            people.Clear();
            teams.Clear();
            Team.reset();
        }

        private List<Person> Shuffle(List<Person> peopleList)
        {
            List<Person> ret = new List<Person>();
            int rNR = 0;
            Random r = new Random();

            for(int i=0; i < peopleList.Count; i++)
            {
                rNR = r.Next(0, peopleList.Count);

                if(peopleList[rNR].State == PersonSTATE.NOT_ALLOCATED)
                {
                    ret.Add(peopleList[rNR]);
                    peopleList[rNR].State = PersonSTATE.ALLOCATED;
                }
                else
                {
                    while(peopleList[rNR].State == PersonSTATE.ALLOCATED)
                    {
                        rNR = r.Next(0, peopleList.Count);

                        if (peopleList[rNR].State == PersonSTATE.NOT_ALLOCATED)
                        {
                            ret.Add(peopleList[rNR]);
                            peopleList[rNR].State = PersonSTATE.ALLOCATED;
                            break;
                        }
                    }
                }
            }

            return ret;
        }
    }
}
