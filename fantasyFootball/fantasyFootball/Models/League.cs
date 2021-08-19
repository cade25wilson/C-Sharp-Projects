using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantasyFootball.Models
{
    public class League
    {
        public int LeagueID { get; set; }
        public int TeamID { get; set; }
        public int PlayerID { get; set; }

        public Team Team { get; set; }
        public Player Player { get; set; }
    }
}
