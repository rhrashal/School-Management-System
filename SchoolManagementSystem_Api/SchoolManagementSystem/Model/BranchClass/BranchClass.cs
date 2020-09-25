using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class BranchClass
    {
            public int Id { get; set; }
            [Required]
            public int BranchId { get; set; }
            [Required]
            public int ShiftId { get; set; }
            [Required]
            public int SchoolVersionId { get; set; }
            [Required]
            public int SchoolClassId { get; set; }
            public virtual SchoolVersion SchoolVersion { get; set; }
            public virtual Shift Shift { get; set; }
            public virtual Branch Branch { get; set; }
            public virtual SchoolClass SchoolClass { get; set; }
            public virtual ICollection<ApplicationForm> ApplicationForm { get; set; }
            public virtual ICollection<ClassRoom> ClassRoom { get; set; }
            public virtual ICollection<Section> Section { get; set; }
            public virtual ICollection<Student> Student { get; set; }
    }

    public class BranchSection
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ShiftId { get; set; }
        public int SchoolVersionId { get; set; }
        public int SchoolClassId { get; set; }
        public int? SectionId { get; set; }
        public int RoomId { get; set; }
        public int? TeacherId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual SchoolVersion SchoolVersion { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }
        public virtual Section Section { get; set; }
        public virtual Room Room { get; set; }
        public virtual Teacher Teacher { get; set; }
        
        public virtual ICollection<ApplicationForm> ApplicationForm { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
