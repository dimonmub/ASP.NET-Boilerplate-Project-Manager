using System.Reflection;
using Abp.Modules;

namespace ProjectManager
{
    public class ProjectManagerCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
