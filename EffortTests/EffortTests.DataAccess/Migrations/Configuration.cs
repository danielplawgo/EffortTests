using Bogus;
using EffortTests.Models;

namespace EffortTests.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EffortTests.DataAccess.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EffortTests.DataAccess.DataContext context)
        {
            if (context.Products.Any() == false)
            {
                var products = new Faker<Product>()
                    .RuleFor(p => p.Name, (f, p) => f.Commerce.Product())
                    .RuleFor(p => p.IsActive, (f, p) => f.Random.Bool())
                    .Generate(20);

                context.Products.AddRange(products);
            }
        }
    }
}
