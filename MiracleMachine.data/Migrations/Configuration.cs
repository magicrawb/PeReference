namespace MiracleMachine.data.Migrations
{
    using models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Props.AddOrUpdate(
                p => p.PropName,
                new Prop() { PropId = 0, PropName = "sharpie" },
                new Prop() { PropId = 1, PropName = "coin" },
                new Prop() { PropId = 2, PropName = "playing cards" },
                new Prop() { PropId = 3, PropName = "coffee mug" },
                new Prop() { PropId = 4, PropName = "phone" },
                new Prop() { PropId = 5, PropName = "keys" },
                new Prop() { PropId = 6, PropName = "sunglasses" },
                new Prop() { PropId = 7, PropName = "headphones" },
                new Prop() { PropId = 8, PropName = "ring" },
                new Prop() { PropId = 9, PropName = "lighter" }
                );
            context.SaveChanges();
            context.Dispose();
        }
    }
}
