using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string TopicName { get; set; }
        [Required]
        [StringLength(1000)]
        public string NoticeBody { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

    }
}
