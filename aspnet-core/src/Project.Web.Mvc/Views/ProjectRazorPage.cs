using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Project.Web.Views
{
    public abstract class ProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ProjectRazorPage()
        {
            LocalizationSourceName = ProjectConsts.LocalizationSourceName;
        }
    }
}
