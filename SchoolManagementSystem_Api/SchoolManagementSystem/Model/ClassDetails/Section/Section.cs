using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class Section
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string SectionName { get; set; }
        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }
        [Required]
        public int BranchClassId { get; set; }
        public virtual BranchClass BranchClass { get; set; }
        public virtual ICollection<ClassRoom> ClassRoom { get; set; }
        public virtual ICollection<Student> Student { get; set; }

        public virtual ICollection<ExamResult> ExamResult { get; set; }
    }
}
