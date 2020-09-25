using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class ClassRoom
    {
        public int Id { get; set; }       
        [Required]
        public int RoomId { get; set; }
        public int? TeacherId { get; set; }
        [Required]
        public int BranchClassId { get; set; }
        public int? SectionId { get; set; }
        public virtual Room Room { get; set; }
        public virtual Section Section { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual BranchClass BranchClass { get; set; }
        public virtual ICollection<ClassRoutine> ClassRoutine { get; set; }        
    }
}
