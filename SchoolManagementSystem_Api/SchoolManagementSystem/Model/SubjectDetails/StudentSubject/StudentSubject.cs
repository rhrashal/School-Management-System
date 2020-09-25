﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class StudentSubject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public bool IsOptional { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }

    }
}
