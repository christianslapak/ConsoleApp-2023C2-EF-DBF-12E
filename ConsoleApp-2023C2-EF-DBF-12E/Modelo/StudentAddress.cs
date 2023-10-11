﻿using System;
using System.Collections.Generic;

namespace ConsoleApp_2023C2_EF_DBF_12E.Modelo
{
    public partial class StudentAddress
    {
        public int StudentId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual Student Student { get; set; }
    }
}
