namespace Online_Game_store.Migrations
{
    using Online_Game_store.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Data.Entity.Validation;

    internal sealed class Configuration : DbMigrationsConfiguration<Online_Game_store.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Online_Game_store.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var publishers = new List<Publisher>
            {
                new Publisher { Name = "Sebi" },
                new Publisher { Name = "Bia"},
                new Publisher { Name = "Alex"},
                new Publisher { Name = "Damian" }
            };
            publishers.ForEach(s => context.Publishers.AddOrUpdate(p => p.PublisherId, s));
            context.SaveChanges();

            var games = new List<Game>
            {
                new Game { GameId = 123, Title = "CS:GO", Creator = "Alexander",
                    DateCreation = DateTime.UtcNow, PublisherId = publishers.Single(p => p.Name == "Sebi").PublisherId },
                new Game { GameId = 1234, Title = "Cs 1.6", Creator = "John",
                    DateCreation = DateTime.UtcNow, PublisherId = publishers.Single(p => p.Name == "Sebi").PublisherId },
                new Game { GameId = 12345, Title = "League of Legends", Creator = "Luca",
                    DateCreation = DateTime.UtcNow, PublisherId = publishers.Single(p => p.Name == "Sebi").PublisherId },
                new Game { GameId = 123456, Title = "World of Warcraft", Creator = "Peter",
                    DateCreation = DateTime.UtcNow, PublisherId = publishers.Single(p => p.Name == "Sebi").PublisherId }
            };
            games.ForEach(s => context.Games.AddOrUpdate(p => p.GameId, s));
            context.SaveChanges();

        }
    }
}
