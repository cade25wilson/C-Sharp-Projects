using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantasyFootball.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Owner { get; set; }
        public int CurrentPlace { get; set; }

        public ICollection<League> Leagues { get; set; }
    }
}
