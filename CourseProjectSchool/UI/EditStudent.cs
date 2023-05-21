using CourseProjectSchool.DB;
using CourseProjectSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            surnameTB.BackColor = Color.White;
            nameTB.BackColor = Color.White;
            patronymicTB.BackColor = Color.White;
            if (!CheckStringSurname(surnameTB.Text))
            {
                surnameTB.BackColor = Color.Red;
                return;
            }
            if (!CheckStringNamePatrononic(nameTB.Text))
            {
                nameTB.BackColor = Color.Red;
                return;
            }
            if (!CheckStringNamePatrononic(patronymicTB.Text))
            {
                patronymicTB.BackColor = Color.Red;
                return;
            }
            Student student = Repository.FindStudentByID(Guid.Parse(id.Text));
            student.Surname = surnameTB.Text;
            student.Name = nameTB.Text;
            student.Patronymic = patronymicTB.Text;
            student.ClassName = comboBox2.Text;
            await Repository.UpdateStudent(student);
            UpdateClassesTableEvent?.Invoke();
        }

        private bool CheckStringSurname(string surname)
        {
            Regex regex = new Regex(@"^[а-яА-Я-]+$");
            return regex.IsMatch(surname);
        }

        private bool CheckStringNamePatrononic(string str)
        {
            Regex regex = new Regex(@"^[а-яА-Я]+$");
            return regex.IsMatch(str);
        }
    }

}
