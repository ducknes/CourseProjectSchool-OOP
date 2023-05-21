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
    public partial class EditClass : Form
    {

        public delegate void UpdateDelegate();
        public event UpdateDelegate UpdateClassesTableEvent;

        public EditClass()
        {
            InitializeComponent();
        }

        private void EditClass_Load(object sender, EventArgs e)
        {

        }

        private void editNewClass_Click(object sender, EventArgs e)
        {
            editClassName.BackColor = Color.White;
            if (!CheckClassName(editClassName.Text))
            {
                editClassName.BackColor = Color.Red;
                return;
            }
            SchoolClass sc = Repository.FindClassById(ClassID.Text);
            sc.Name = editClassName.Text;
            Repository.UpdataClass(sc);
            UpdateClassesTableEvent?.Invoke();
        }

        private bool CheckClassName(string classname)
        {
            Regex regex = new Regex(@"^[1-9|10|11]{1,2}[а-я]{1}$");
            return regex.IsMatch(classname);
        }
    }
}
