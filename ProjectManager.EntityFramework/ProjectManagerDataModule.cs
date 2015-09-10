using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using ProjectManager.EntityFramework;

namespace ProjectManager
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ProjectManagerCoreModule))]
    public class ProjectManagerDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ProjectManagerDbContext>(null);
        }
    }
}
