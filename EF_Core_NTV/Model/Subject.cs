using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_NTV.Model
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string Title { get; set; }
        public List<Mark> Marks { get; } = new();
        public ICollection<Teacher> Teacher { get; set; }
    }
}
