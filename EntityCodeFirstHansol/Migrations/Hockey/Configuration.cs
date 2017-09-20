namespace EntityCodeFirstHansol.Migrations.Hockey
{
    using EntityCodeFirstHansol.Data;
    using EntityCodeFirstHansol.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityCodeFirstHansol.Data.HockeyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Hockey";
        }

        protected override void Seed(EntityCodeFirstHansol.Data.HockeyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Teams.AddOrUpdate( t => t.Name,
                   getTeams().ToArray()
            );
            context.SaveChanges();

            context.Players.AddOrUpdate( t => new { t.FirstName, t.LastName },
                getPlayers(context).ToArray()
            );

            context.SaveChanges();
        }

        private List<Player> getPlayers(HockeyContext context)
        {
            List<Player> players = new List<Player>()
            {
                new Player()
                {
                    JerseyNumber = 70,
                    FirstName = "Bob",
                    LastName = "Smith",
                    Position = "Goalie",
                    Country = "Canada",
                    TeamId = context.Teams.FirstOrDefault(t => t.Name == "Canucks").TeamId

                },
                 new Player()
                {
                    JerseyNumber = 45,
                    FirstName = "Tom",
                    LastName = "Jones",
                    Position = "Right Wings",
                    Country = "Sweden",
                    TeamId = context.Teams.FirstOrDefault(t => t.Name == "Canucks").TeamId

                },
                   new Player()
                {
                    JerseyNumber = 23,
                    FirstName = "Bill",
                    LastName = "Stevens",
                    Position = "Center",
                    Country = "France",
                    TeamId = context.Teams.FirstOrDefault(t => t.Name == "Canucks").TeamId

                },

                   new Player()
                {
                    JerseyNumber = 33,
                    FirstName = "Joe",
                    LastName = "Stevens",
                    Position = "Goalie",
                    Country = "Canada",
                    TeamId = context.Teams.FirstOrDefault(t => t.Name == "Sharks").TeamId

                },

                   new Player()
                {
                    JerseyNumber = 103,
                    FirstName = "Tim",
                    LastName = "Jones",
                    Position = "Depense",
                    Country = "US",
                    TeamId = context.Teams.FirstOrDefault(t => t.Name == "Sharks").TeamId

                },
                     new Player()
                {
                    JerseyNumber = 73,
                    FirstName = "Jason",
                    LastName = "Stevens",
                    Position = "Left Wings",
                    Country = "US",
                    TeamId = context.Teams.FirstOrDefault(t => t.Name == "Sharks").TeamId

                }
            };
            return players;
            
        }

        private List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team() { Name= "Canucks", City="Vancouver" },
                new Team() { Name= "Oilers", City="Edmonton" },
                new Team() { Name= "Flames", City="Calgary" },
                new Team() { Name= "Sharks", City="Calgary" }

            };
            return teams;
        }
         
    }
}
