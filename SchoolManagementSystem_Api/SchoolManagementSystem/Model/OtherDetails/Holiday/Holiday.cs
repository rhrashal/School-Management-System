using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class Holiday
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string HolidayName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public Nullable<int> NumberOfDay { get; set; }
    }
}
