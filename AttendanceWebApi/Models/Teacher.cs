namespace AttendanceWebApi.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? PasswordHash { get; set; }

        public string? Email { get; set; }

    }
}
