using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class Subject
    {  [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string SubjectName { get; set; }
        [Required]
        [StringLength(6)]
        public string SubjectCode { get; set; }
        [Required]
        public int SchoolClassId { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }
        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }
        public int? SchoolVersionId { get; set; }
        public virtual SchoolVersion SchoolVersion { get; set; }
        public virtual ICollection<ClassRoutine> ClassRoutine { get; set; }
        //public virtual ICollection<ExamMark> ExamMark { get; set; }
        public virtual ICollection<ExamRoutine> ExamRoutine { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
