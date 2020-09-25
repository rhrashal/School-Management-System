using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class AttendanceOfTeacher
    {
        public int Id { get; set; }
        public DateTime AttendTime { get; set; }
        public DateTime? LeaveTime { get; set; }
        public int  TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
