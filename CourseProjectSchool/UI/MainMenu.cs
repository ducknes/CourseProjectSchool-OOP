using CourseProjectSchool.DB;
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
    }
}
