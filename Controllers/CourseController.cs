using course_apply_dotnet_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace course_apply_dotnet_project.Controllers
{
    public class CourseController :Controller
    {
        public IActionResult Index()
        {
            return View();
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
            return Redirect("/");
        }
    }
}