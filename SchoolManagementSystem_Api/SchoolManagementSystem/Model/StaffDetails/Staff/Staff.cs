using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class Staff 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [StringLength(8)]
        [DataType(DataType.Password)]
        [NotMapped]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Password Not match!")]
        public string ConfirmPassword { get; set; }
        [Required]
        public int Gender { get; set; }
        [Required]
        public int Religion { get; set; }
        [Required]
        [StringLength(15)]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string NationalIdNo { get; set; }
        [StringLength(1000)]
        public string ImageUrl { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        [StringLength(100)]
        public string FathersName { get; set; }
        [Required]
        [StringLength(100)]
        public string MothersName { get; set; }
        [Required]
        public bool MaritalStatus { get; set; }
        [Required]
        public bool IsPresent { get; set; } // Staff is in leave??
        [Required]
        public DateTime JoiningDate { get; set; }
        public DateTime? ResignDate { get; set; }
        [Required]
        [StringLength(500)]
        public string PresentAddress { get; set; }
        [Required]
        [StringLength(500)]
        public string ParmanentAddress { get; set; }
        public string FingerData { get; set; }
        [Required]
        public int PostOfficeId { get; set; }
        public virtual PostOffice PostOffice { get; set; }
        [Required]
        public int BranchId { get; set; }
        [Required]
        public int DesignationId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual ICollection<AttendanceOfStaff> AttendanceOfStaff { get; set; }
    }
}
