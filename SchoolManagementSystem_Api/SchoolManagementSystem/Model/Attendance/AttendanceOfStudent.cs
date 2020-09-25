using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class AttendanceOfStudent
    {
        public int Id { get; set; }
        public DateTime AttendTime { get; set; }
        public DateTime? LeaveTime { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
