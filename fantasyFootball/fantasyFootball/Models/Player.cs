using System;
using System.Collections.Generic;

namespace fantasyFootball.Models
{
     public enum Position
     {
         QB, WR, RB, TE, OL, D, K
     }

     public class Player
     {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Position? Position { get; set; }
        public DateTime AddedDate { get; set; }

        public ICollection<League> Leagues { get; set; }
    }
}
