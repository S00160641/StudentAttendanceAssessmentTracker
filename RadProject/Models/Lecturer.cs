using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadProject.Models
{
    [Table("Lecturer")]
    public class Lecturer
    {
        // Lecturer ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Lecturer ID")]
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