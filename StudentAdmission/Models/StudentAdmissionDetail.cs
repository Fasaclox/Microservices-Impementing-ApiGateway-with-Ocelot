using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAdmission.Models
{
    [Table("StudentAdmissionDetails")]
    public class StudentAdmissionDetail
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public string StudentClass { get; set; }
            public DateTime DateofJoining { get; set; }
        
    }
}

