using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectSchool.Models
{
    class Student
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string ClassName { get; set; }
        public Dictionary<string, List<int>> Marks { get; set; } = new Dictionary<string, List<int>>();
        public float AverageAttendance { get; set; }

        public Student(string name, string surname, string patronymic, string className)
        {
            ID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            ClassName = className;
        }
    }
}
