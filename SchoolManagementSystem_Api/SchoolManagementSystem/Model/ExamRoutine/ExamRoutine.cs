using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class ExamRoutine
    {
        public int Id { get; set; }
        [Required]
        public DateTime ExamDate { get; set; }
        [Required]
        public int TotalNumber { get; set; }
        [Required]
        public int SchoolClassId { get; set; }
        [Required]
        public int ExamId { get; set; }
        [Required]
        public int ShiftId { get; set; }
        [Required]
        public int SubjectId { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<ExamMark> ExamMark { get; set; }
    }
}
