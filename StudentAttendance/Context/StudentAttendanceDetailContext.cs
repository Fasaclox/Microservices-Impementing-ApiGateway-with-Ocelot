using Microsoft.EntityFrameworkCore;
using StudentAttendance.Models;

namespace StudentAttendance.Context
{
    public class StudentAttendanceDetailContext : DbContext
    {
        public StudentAttendanceDetailContext(DbContextOptions<StudentAttendanceDetailContext> options)
            : base(options)
        { 
        }
        public DbSet<StudentAttendanceDetail> StudentAttendanceDetails { get; set; }
    }
}
