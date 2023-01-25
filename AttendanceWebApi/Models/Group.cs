namespace AttendanceWebApi.Models
{
    public class Group
    {

        public Group()
        {
            Teachers= new HashSet<Teacher>();
        }
        public int Id { get; set; }

        public string? Name { get; set; }

        public int TeacherId { get; set; }

        public ICollection<Teacher>? Teachers { get; set; }
    }
}
