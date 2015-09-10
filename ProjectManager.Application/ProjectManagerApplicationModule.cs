using System.Reflection;
using Abp.Modules;

namespace ProjectManager
{
    [DependsOn(typeof(ProjectManagerCoreModule))]
    public class ProjectManagerApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
