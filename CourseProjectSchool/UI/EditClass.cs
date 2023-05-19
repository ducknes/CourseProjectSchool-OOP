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
            SchoolClass sc = Repository.FindClassById(ClassID.Text);
            sc.Name = editClassName.Text;
            Repository.UpdataClass(sc);
            UpdateClassesTableEvent?.Invoke();
        }
    }
}
