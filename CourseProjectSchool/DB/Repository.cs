using CourseProjectSchool.Models;
using CourseProjectSchool.UI;
using Microsoft.EntityFrameworkCore.Sqlite.Query.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CourseProjectSchool.DB
{
    class Repository
    {

        public static string CLASS_JSON = @"C:\dev\projects\CourseProjectSchool\CourseProjectSchool\DB\Classes.json";

        public static string STUDENTS_JSON = @"C:\dev\projects\CourseProjectSchool\CourseProjectSchool\DB\Students.json";

        public static string REPORT_PATH = @"C:\dev\projects\CourseProjectSchool\CourseProjectSchool\Reports\отчет.docx";

        public static List<SchoolClass> Classes = new List<SchoolClass>();

        public static List<Student> Students = new List<Student>();

        public static async Task WriteToJson<T>(List<T> data, string file_name)
        {
            using (var writer = new StreamWriter(file_name, false)) 
            {
                await writer.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        public static async Task<List<T>> ReadFromJson<T>(string file_name)
        {
            using (var reader = new StreamReader(file_name))
            {
                return await Task.Run(async () => 
                JsonConvert.DeserializeObject<List<T>>(await reader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        public static async void WriteToReportFile(string file_name, string report)
        {
            using (StreamWriter writer = new StreamWriter(file_name, false))
            {
                await writer.WriteLineAsync(report);
            }
        }

        public static async void InitStudentFile()
        {
            Students = await ReadFromJson<Student>(STUDENTS_JSON);
        }

        public static async void InitClassesFile()
        {
            Classes = await ReadFromJson<SchoolClass>(CLASS_JSON);
        }

        public static SchoolClass FindClassByName(string name)
        {
            return (from sc in Classes where sc.Name == name select sc).First();
        }

        public static IEnumerable<SchoolClass> FindClassesByName(string name)
        {
            return from sc in Classes where sc.Name.Contains(name) select sc;
        }

        public static SchoolClass FindClassById(string id)
        {
            return (from sc in Classes where sc.ID == Guid.Parse(id) select sc).First();
        }

        public static IEnumerable<Student> FindStudenstsBySurname(string surname)
        {
            return from s in Students where s.Surname.Contains(surname) select s;
        }

        public static async void UpdataClass(SchoolClass sc)
        {
            foreach (var items in Classes)
            {
                if (items.ID == sc.ID)
                {
                    items.Name = sc.Name;
                    items.AverageAttendance = sc.AverageAttendance;
                    items.AveragePerformance = sc.AveragePerformance;
                    await WriteToJson(Classes, CLASS_JSON);
                    return;
                }
            }
        }

        public static async Task UpdateStudent(Student student)
        {
            foreach (var item in Students)
            {
                if (item.ID == student.ID)
                {
                    item.Name = student.Name;
                    item.Surname = student.Surname;
                    item.Patronymic = student.Patronymic;
                    item.ClassName = student.ClassName;
                    item.Marks = student.Marks;
                    item.AverageAttendance = student.AverageAttendance;
                    item.AveragePerformance = student.AveragePerformance;
                    await WriteToJson(Students, STUDENTS_JSON);
                    return;
                }
            }
        }

        public static async void DeleteClass(string name)
        {
            SchoolClass sc = FindClassByName(name);
            List<Student> students = FindStudensByClassName(sc.Name).ToList();
            Classes.Remove(sc);
            foreach (Student student in students)
            {
                Students.Remove(student);
            }
            await WriteToJson(Classes, CLASS_JSON);
        }

        public static async void DeleteStudent(Guid id)
        {
            Student student = FindStudentByID(id);
            Students.Remove(student);
            await WriteToJson(Students, STUDENTS_JSON);
        }

        public static Student FindStudentByID(Guid id)
        {
            return (from s in Students where s.ID == id select s).First();
        }

        public static int CountStudents(string className)
        {
            return (from s in Students where s.ClassName == className select s).Count();
        }

        public static IEnumerable<Student> FindStudensByClassName(string className)
        {
            return from s in Students where s.ClassName == className select s;
        }

        public static IEnumerable<SchoolClass> GetSortedClasses()
        {
            return Classes.OrderBy(sc => int.Parse(sc.Name.Substring(0, sc.Name.Length - 1)))
                .ThenBy(sc => sc.Name.Substring(sc.Name.Length - 1));
        }

        public static IEnumerable<Student> GetSortedStudents()
        {
            return Students.OrderBy(s => s.Surname);
        }

        public static float GetAverageStudentPerformance(Guid id)
        {
            Student student = FindStudentByID(id);
            float sumMarks = 0;
            float countMarks = 0;
            foreach (var item in student.Marks)
            {
                foreach (var elem in item.Value)
                {
                    switch (elem)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        default:
                            sumMarks += elem;
                            countMarks++;
                            break;
                    }
                }
            }
            student.AveragePerformance = sumMarks / countMarks;
            return sumMarks / countMarks;
        }

        public static float CountAverageAttendance(Guid id)
        {
            Student student = FindStudentByID(id);
            float sumLessons = 0;
            float countOnLesson = 0;
            foreach (var item in student.Marks)
            {
                foreach (var elem in item.Value)
                {
                    switch (elem)
                    {
                        case 0:
                            sumLessons++;
                            break;
                        case 1:
                            sumLessons++;
                            countOnLesson++;
                            break;
                        default:
                            sumLessons++;
                            countOnLesson++;
                            break;
                    }
                }
            }
            student.AverageAttendance = (countOnLesson / sumLessons) * 100f;
            return (countOnLesson / sumLessons) * 100f;
        }

        public static float GetAverageClassPerformance(Guid id)
        {
            SchoolClass schoolClass = FindClassById(id.ToString());
            float sumPerf = Students.Where(s => s.ClassName == schoolClass.Name).Sum(s => s.AveragePerformance);
            float count = Students.Where(s => s.ClassName == schoolClass.Name).Count();
            schoolClass.AveragePerformance = sumPerf / count;
            return schoolClass.AveragePerformance;
        }

        public static float GetAverageClassAttendance(Guid id)
        {
            SchoolClass schoolClass = FindClassById(id.ToString());
            float sumPerf = Students.Where(s => s.ClassName == schoolClass.Name).Sum(s => s.AverageAttendance);
            float count = Students.Where(s => s.ClassName == schoolClass.Name).Count();
            schoolClass.AverageAttendance = sumPerf / count;
            return schoolClass.AverageAttendance;
        }

        public static async void DeleteAll()
        {
            Classes.Clear();
            Students.Clear();
            await WriteToJson(Classes, CLASS_JSON);
            await WriteToJson(Students, STUDENTS_JSON);
        }

        public static IEnumerable<SchoolClass> GetClassWithSelectedAveragePerformance()
        {
            return from c in Classes where c.AveragePerformance > 4.5f select c;
        }

        public static IEnumerable<SchoolClass> GetClassWithSelectedAverageAttendance()
        {
            return from c in Classes where c.AverageAttendance > 85.0f select c;
        }

        public static IEnumerable<Student> GetStudentsWithSelectedAveragePerformance()
        {
            return from s in Students where s.AveragePerformance > 4.5f select s;
        }

        public static IEnumerable<Student> GetStudentsWithSelectedAverageAttendance()
        {
            return from s in Students where s.AverageAttendance > 85.0f select s;
        }
    }
}
