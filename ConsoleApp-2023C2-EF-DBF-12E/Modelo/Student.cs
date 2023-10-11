using System;
using System.Collections.Generic;

namespace ConsoleApp_2023C2_EF_DBF_12E.Modelo
{
    public partial class Student
    {
        public Student()
        {
            StudentCourse = new HashSet<StudentCourse>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? StandardId { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual Standard Standard { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }
        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
