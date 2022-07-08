using Microsoft.EntityFrameworkCore;
using StudentAdmission.Models;

namespace StudentAdmission.Context
{
    public class StudentAdmissionDetailContext : DbContext
    {
        public StudentAdmissionDetailContext(DbContextOptions<StudentAdmissionDetailContext> options)
            : base(options)
        {
        }
        public DbSet<StudentAdmissionDetail> StudentAdmissionDetails { get; set; }
    }
}
