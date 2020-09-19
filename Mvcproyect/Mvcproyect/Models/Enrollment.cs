using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvcproyect.Models
{
    public class Enrollment
    {
        public enum Paralelo
        {
            A, B, C, D, F
        }
        [Key]
        public int EnrollmentID { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Paralelo Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}