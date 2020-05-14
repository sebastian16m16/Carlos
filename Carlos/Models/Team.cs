using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos.Models
{
    class Team : List<Person>
    {
        public STATE State { get; set; }
        private static int id  { get; set; }
        public int TeamID { get; set; }

        public Team()
        {
            id += 1;
            this.TeamID = id;
            this.State = STATE.UNBLOCKED;
        }

        public Team(STATE state)
        {
            id += 1;
            this.TeamID = id;
            State = state;
        }

        public static void reset()
        {
            id = 0;
        }
    }
}
