using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string RoomName { get; set; }
        [Required]
        public int SitCapacity { get; set; }
        [Required]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ICollection<ClassRoom> ClassRoom { get; set; }
    }
}
