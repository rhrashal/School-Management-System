﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class RulesRegulation
    {
        public int Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string RuleDetails { get; set; }
        [Required]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
