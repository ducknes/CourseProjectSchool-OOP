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
    public partial class EditStudent : Form
    {

        public delegate void UpdateDelegate();
        public event UpdateDelegate UpdateClassesTableEvent;

        public EditStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = Repository.FindStudentByID(Guid.Parse(id.Text));
            student.Surname = surnameTB.Text;
            student.Name = nameTB.Text;
            student.Patronymic = patronymicTB.Text;
            student.ClassName = comboBox2.Text;
            Repository.UpdateStudent(student);
            UpdateClassesTableEvent?.Invoke();
        }
    }
}
