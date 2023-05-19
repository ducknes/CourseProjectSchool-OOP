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
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        private async void Init_Load(object sender, EventArgs e)
        {
            Repository.InitClassesFile();
            Repository.InitStudentFile();
            // await End();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private static async Task End()
        {
            await Task.Delay(30000);
            Application.Exit();
        }
    }
}
