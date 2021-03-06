﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class Teacher 
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
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
        [StringLength(8)]
        [DataType(DataType.Password)]
        [NotMapped]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Password Not match!")]
        public string ConfirmPassword { get; set; }
        [Required]
        public bool IsPresent { get; set; } // Teacher is in leave??
        [StringLength(1000)]
        public string ImageUrl { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public bool MaritalStatus { get; set; }
        [Required]
        [StringLength(100)]
        public string FathersName { get; set; }
        [Required]
        [StringLength(100)]
        public string MothersName { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        public DateTime? ResignDate { get; set; }
        public string FingerData { get; set; }
        [Required]
        public int BranchId { get; set; }
        public int? DesignationId { get; set; }
        //public int? SubjectId { get; set; }
        public virtual Branch Branch { get; set; }       
        public virtual Designation Designation { get; set; }
        //public virtual Subject Subject { get; set; }
        public virtual ICollection<ClassRoutine> ClassRoutine { get; set; }
        public virtual ICollection<ClassRoom> ClassRoom { get; set; }
        public virtual ICollection<AttendanceOfTeacher> AttendanceOfTeacher { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeacher { get; set; }
    }
}
