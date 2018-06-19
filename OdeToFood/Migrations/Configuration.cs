namespace OdeToFood.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Models.Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA"},
                new Models.Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
                new Models.Restaurant
                {
                    Name = "Smaka",
                    City = "Gothenburg",
                    Country = "Sweden",
                    Reviews = 
                        new List<Models.RestaurantReview> {
                            new Models.RestaurantReview {Rating = 9, Body = "Great Food!", ReviewerName = "Scott"}
                    }
                }

                );  
        }
    }
}
