﻿using System;
using System.Collections.Generic;

namespace ConsoleApp_2023C2_EF_DBF_12E.Modelo
{
    public partial class Course
    {
        public Course()
        {
            StudentCourse = new HashSet<StudentCourse>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
