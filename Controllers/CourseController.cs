using course_apply_dotnet_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace course_apply_dotnet_project.Controllers
{
    public class CourseController :Controller
    {
        public IActionResult Index()
        {
            var model=Repository.Applications;
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult Apply([FromForm] Candidate model)
        {
            Repository.Add(model);
            return View("Feedback", model);
        }
    }
}