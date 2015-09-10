using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace ProjectManager
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ProjectManagerApplicationModule))]
    public class ProjectManagerWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ProjectManagerApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
