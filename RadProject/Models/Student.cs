using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadProject.Models
{
    [Table("Student")]
    public class Student
    {
        // Student ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student ID")]
        public int StudentID { get; set; }

        // First Name
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        // Last Name
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // Modules
        public virtual Module associatedModules { get; set; }
    }
}