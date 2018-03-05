using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadProject.Models
{
    [Table("Module")]
    public class Module
    {
        // Module ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Module ID")]
        public int ModuleID { get; set; }

        // Module Name
        [Display(Name = "Name")]
        public string Name { get; set; }

        // Lecturer
        [Display(Name = "Lecturer")]
        [Key, ForeignKey("Lecturer"), Column(Order = 0)]
        public int LecturerID { get; set; }

        // Students
        public virtual ICollection<Student> studentsInModule { get; set; }
    }
}