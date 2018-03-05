using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadProject.Models
{
    [Table("StudentModule")]
    public class StudentModule
    {
        // Student ID
        [Display(Name = "Student ID")]
        [Key, ForeignKey("Student"), Column(Order = 0)]
        public virtual ICollection<Student> Student { get; set; }

        // Module ID
        [Display(Name = "Module ID")]
        [Key, ForeignKey("Module"), Column(Order = 1)]
        public virtual ICollection<Module> Module { get; set; }

        // Attendance
        [Display(Name = "Attendance")]
        public double Attendance { get; set; }
    }
}