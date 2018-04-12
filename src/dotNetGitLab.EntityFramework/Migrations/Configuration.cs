using System.Data.Entity.Migrations;

namespace dotNetGitLab.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<dotNetGitLab.EntityFramework.dotNetGitLabDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "dotNetGitLab";
        }

        protected override void Seed(dotNetGitLab.EntityFramework.dotNetGitLabDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
