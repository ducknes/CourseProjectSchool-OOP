using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectSchool.Models
{
    class SchoolClass
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public List<Student>? Students { get; set; }

    }
}
