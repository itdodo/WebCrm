using System.Collections.Generic;
using Do.Entity;

namespace Do.Dal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Do.Dal.TestDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Do.Dal.TestDb context)
        {

            //var list = new List<Menu>()
            //{
            //    new Menu() {MenuName = "²Ëµ¥1",MenuUrl = "/test/test1"},
            //    new Menu() {MenuName = "²Ëµ¥2",MenuUrl = "/test/test2"},
            //    new Menu() {MenuName = "²Ëµ¥3",MenuUrl = "/test/test3"}
            //};
            //context.Menus.AddRange(list);
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
