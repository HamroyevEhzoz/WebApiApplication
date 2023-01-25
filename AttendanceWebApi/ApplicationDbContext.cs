using AttendanceWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceWebApi
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
       


        public DbSet<Teacher> Teachers => Set<Teacher>();

        public  DbSet<Student> Students => Set<Student>();

        public DbSet<Group> Groups => Set<Group>();

        public DbSet<Attendance> Attendances => Set<Attendance>();

    }
}
