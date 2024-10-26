using course_apply_dotnet_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace course_apply_dotnet_project.Controllers
{
    public static class Repository
    {
        private static List<Candidate> applications =new();
        public static IEnumerable<Candidate> Applications => applications;
        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}