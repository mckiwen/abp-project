using Abp.AspNetCore.Mvc.ViewComponents;

namespace Project.Web.Views
{
    public abstract class ProjectViewComponent : AbpViewComponent
    {
        protected ProjectViewComponent()
        {
            LocalizationSourceName = ProjectConsts.LocalizationSourceName;
        }
    }
}
