using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAttendance.Models
{
    [Table("StudentAttendanceDetails")]
    public class StudentAttendanceDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public double AttendencePercentage { get; set; }
    }
}
