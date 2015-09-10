using Abp.Web.Mvc.Views;

namespace ProjectManager.Web.Views
{
    public abstract class ProjectManagerWebViewPageBase : ProjectManagerWebViewPageBase<dynamic>
    {

    }

    public abstract class ProjectManagerWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ProjectManagerWebViewPageBase()
        {
            LocalizationSourceName = ProjectManagerConsts.LocalizationSourceName;
        }
    }
}