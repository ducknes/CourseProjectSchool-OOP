using Newtonsoft.Json;
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
        public string Name { get; set; }
        [JsonIgnore]
        public static List<string> Lessons { get; set; } = new List<string>() { "Математика", "Русский язык","Информатика", "Физика", "Английский язык"};

        public SchoolClass() 
        { 
            ID = Guid.NewGuid();    
        }

        public SchoolClass(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
        }
    }
}
