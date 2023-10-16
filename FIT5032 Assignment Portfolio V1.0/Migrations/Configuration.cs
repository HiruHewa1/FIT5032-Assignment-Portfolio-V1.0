namespace FIT5032_Assignment_Portfolio_V1._0.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FIT5032_Assignment_Portfolio_V1._0.Context.UltrasoundDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FIT5032_Assignment_Portfolio_V1._0.Context.UltrasoundDbContext";
        }

        protected override void Seed(FIT5032_Assignment_Portfolio_V1._0.Context.UltrasoundDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
