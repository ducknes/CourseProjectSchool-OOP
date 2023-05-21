using CourseProjectSchool.DB;
using CourseProjectSchool.UI;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentRecord studentRecord = new StudentRecord();
            studentRecord.Show();
            this.Hide();
        }

        private async void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            await Repository.WriteToJson(Repository.Classes, Repository.CLASS_JSON);
            await Repository.WriteToJson(Repository.Students, Repository.STUDENTS_JSON);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            СlassRecord сlassRecord = new СlassRecord();
            сlassRecord.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалиттьв всю базу данных???", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Repository.DeleteAll();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}
