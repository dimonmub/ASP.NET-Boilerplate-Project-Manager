using System.Data.Entity.Migrations;

namespace ProjectManager.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjectManager.EntityFramework.ProjectManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ProjectManager";
        }

        protected override void Seed(ProjectManager.EntityFramework.ProjectManagerDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
