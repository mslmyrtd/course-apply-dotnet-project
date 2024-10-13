namespace course_apply_dotnet_project.Models
{
    public class Candidate
    {
        public string Email {get;set;}=string.Empty;
        public string FirstName {get;set;}=string.Empty;
        public string LastName {get;set;}=string.Empty;
        public string SelectedCourse {get;set;}=string.Empty;
        public DateTime ApplyAt {get;set;}
        public int Age {get;set;}
        public Candidate()
        {
            ApplyAt=DateTime.Now;
        }
    }
}