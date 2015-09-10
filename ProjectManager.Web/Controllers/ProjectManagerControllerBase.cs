using Abp.Web.Mvc.Controllers;

namespace ProjectManager.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ProjectManagerControllerBase : AbpController
    {
        protected ProjectManagerControllerBase()
        {
            LocalizationSourceName = ProjectManagerConsts.LocalizationSourceName;
        }
    }
}