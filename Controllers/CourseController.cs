using Microsoft.AspNetCore.Mvc;

namespace course_apply_dotnet_project
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
    }
}