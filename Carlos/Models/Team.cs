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

        public Team()
        {
            this.State = STATE.UNBLOCKED;
        }

        public Team(STATE state)
        {
            State = state;
        }
    }
}
