using CourseProjectSchool.DB;
using CourseProjectSchool.Models;
using CourseProjectSchoool;
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
    public partial class AddClass : Form
    {
        public delegate void UpdateDelegate();
        public event UpdateDelegate UpdateClassesTableEvent;

        public AddClass()
        {
            InitializeComponent();
        }

        private void AddClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private async void saveNewClass_Click(object sender, EventArgs e)
        {
            if (newClassName.Text != String.Empty)
            {
                SchoolClass schoolClass = new SchoolClass(newClassName.Text);
                Repository.Classes.Add(schoolClass);
                UpdateClassesTableEvent?.Invoke();
                await Repository.WriteToJson(Repository.Classes, Repository.CLASS_JSON);
            }
        }

        private void AddClass_Load(object sender, EventArgs e)
        {

        }
    }
}
