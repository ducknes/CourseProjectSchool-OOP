using CourseProjectSchool.DB;
using CourseProjectSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectSchool.UI
{
    public partial class AddStudent : Form
    {

        public delegate void UpdateDelegate();
        public event UpdateDelegate UpdateClassesTableEvent;

        public AddStudent()
        {
            InitializeComponent();
            foreach (var item in Repository.Classes)
            {
                comboBox2.Items.Add(item.Name);
            }
            comboBox2.SelectedIndex = 0;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(nameTB.Text, surnameTB.Text, patronymicTB.Text, comboBox2.Text);
            foreach (var item in SchoolClass.Lessons)
            {
                student.Marks.Add(item, new List<int>());
            }
            Repository.Students.Add(student);
            UpdateClassesTableEvent?.Invoke();
            await Repository.WriteToJson(Repository.Students, Repository.STUDENTS_JSON);
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

    }
}
