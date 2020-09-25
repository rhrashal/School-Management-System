using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class AttendanceOfStaff
    {
        public int Id { get; set; }
        public DateTime AttendTime { get; set; }
        public DateTime? LeaveTime { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
