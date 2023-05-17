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

namespace CourseProjectSchoool
{
    public partial class StudentRecord : Form
    {
        public StudentRecord()
        {
            InitializeComponent();
        }

        ApplicationDbContext applicationDbContext = new ApplicationDbContext();

        private void StudentRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {

        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student(
                nameTB.Text,
                surnameTB.Text,
                patronymicTB.Text,
                classTB.Text,
                float.Parse(avgPerfTB.Text),
                float.Parse(avgAttTB.Text)
            );

            applicationDbContext.Students.Add(student);
            if (applicationDbContext.SaveChanges() > 0)
            {
                MessageBox.Show("Успешно добавлен", "Добавление ученика", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Неудалось добавить", "Добавление ученика", MessageBoxButtons.OK);
            }
        }
    }
}
