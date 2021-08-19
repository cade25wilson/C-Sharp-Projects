using System;
using System.Linq;
using fantasyFootball.Models;

namespace fantasyFootball.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LeagueContext context)
        {
            context.Database.EnsureCreated();

            // Look for players
            if (context.Players.Any())
            {
                return; // DB has been seeded
            }

            var players = new Player[]
            {
                new Player{ID=1,FirstName="Russel",LastName="Wilson",Position=Position.QB,AddedDate=DateTime.Parse("2021-08-18")}
            };
            foreach (Player p in players)
            {
                context.Players.Add(p);
            }
            context.SaveChanges();

            var teams = new Team[]
            {
                new Team{TeamID=1, Owner="Cade",CurrentPlace=1}
            };
            foreach(Team t in teams)
            {
                context.Teams.Add(t);
            }
            context.SaveChanges();

            var leagues = new League[]
            {
                new League{LeagueID=1,TeamID=1,PlayerID=1}
            };
            foreach(League l in leagues)
            {
                context.Leagues.Add(l);
            }
            context.SaveChanges();

        }
    }
}
