using Abp.Application.Services;

namespace ProjectManager
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ProjectManagerAppServiceBase : ApplicationService
    {
        protected ProjectManagerAppServiceBase()
        {
            LocalizationSourceName = ProjectManagerConsts.LocalizationSourceName;
        }
    }
}