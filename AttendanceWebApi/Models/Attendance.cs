namespace AttendanceWebApi.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        public DateTime DateToday { get; set;}

        public int StudentId { get; set; }

        public int GruopId { get; set; }
        public bool Check { get; set; }

        public Group? Group { get; set; }

        public Student? Student { get; set; }


    }
}
