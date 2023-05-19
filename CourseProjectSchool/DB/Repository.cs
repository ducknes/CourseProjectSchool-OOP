using CourseProjectSchool.Models;
using Microsoft.EntityFrameworkCore.Sqlite.Query.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
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
                    await WriteToJson(Classes, CLASS_JSON);
                    return;
                }
            }
        }

        public static async void UpdateStudent(Student student)
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
                    await WriteToJson(Students, STUDENTS_JSON);
                    return;
                }
            }
        }

        public static async void DeleteClass(string name)
        {
            SchoolClass sc = FindClassByName(name);
            Classes.Remove(sc);
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
    }
}
