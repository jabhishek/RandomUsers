using KnockOutDemos.Infrastructure;
using KnockOutDemos.Models;

namespace KnockOutDemos.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KnockOutDemos.Infrastructure.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EFDbContext context)
        {
            context.Users.AddOrUpdate(
                p => new { p.LastName, p.FirstName },
                new RandomUser
                {
                    Gender = "Female",
                    Title = "Ms",
                    FirstName = "Lillian",
                    LastName = "Ross",
                    Street = "4920 spring st",
                    City = "Spokane",
                    ImageUrl = "http://api.randomuser.me/0.2/portraits/women/35.jpg",
                    State = "Maine",
                    Zip = "40159"
                })
                ;
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
        }
    }
}
