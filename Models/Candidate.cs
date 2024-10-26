using System.ComponentModel.DataAnnotations;

namespace course_apply_dotnet_project.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="E-mail is required")]
        public string Email {get;set;}=string.Empty;
        [Required(ErrorMessage ="FirstName is required")]

        public String? FirstName {get;set;}=string.Empty;
        [Required(ErrorMessage ="LastName is required")]

        public String? LastName {get;set;}=string.Empty;
        public String? FullName  => $"{FirstName} {LastName?.ToUpper()}";
        public string SelectedCourse {get;set;}=string.Empty;
        public DateTime ApplyAt {get;set;}
        public int Age {get;set;}
        public Candidate()
        {
            ApplyAt=DateTime.Now;
        }
    }
}