﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_NTV.Model
{
    internal class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public List<Student> Student { get; } = new();
    }
}
