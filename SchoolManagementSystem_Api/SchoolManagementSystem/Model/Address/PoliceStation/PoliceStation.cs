using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class PoliceStation
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string PoliceStationName { get; set; }
        [Required]
        public int DistrictId { get; set; }
        
        public virtual District District { get; set; }
        
        public virtual ICollection<PostOffice> PostOffice { get; set; }

    }
}
