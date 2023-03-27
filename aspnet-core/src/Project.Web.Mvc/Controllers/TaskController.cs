using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Project.Tasks;
using Project.Tasks.Dtos;
using Project.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Project.Controllers;


namespace Project.Web.Controllers
{
    public class TasksController : ProjectControllerBase
    {
        private readonly ITaskAppService _taskAppService;

        public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items);
            return View(model);
        }
    }
}
