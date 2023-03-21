using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Project.Controllers;

namespace Project.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
