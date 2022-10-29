namespace gcp.simpleapi.Migrations
{
    using gcp.angular.first.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<gcp.angular.first.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(gcp.angular.first.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.userProfiles.Add(new UserProfile()
            {
                Address = "14826 Vienna",
                Name = "Adhar",
                EmailId = "aaaaqsasss@aa.com",
                Phone = "222-333-4444"

            });
        }
    }
}
