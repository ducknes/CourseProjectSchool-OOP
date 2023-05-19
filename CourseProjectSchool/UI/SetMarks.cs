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
    public partial class SetMarks : Form
    {
        public SetMarks()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SetMarks_Load(object sender, EventArgs e)
        {
            foreach (var clas in Repository.Classes)
            {
                comboBoxClass.Items.Add(clas.Name);
            }
            foreach (var lesson in SchoolClass.Lessons)
            {
                comboBoxLesson.Items.Add(lesson);
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBoxLesson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findMarks_Click(object sender, EventArgs e)
        {
            List<Student> students = Repository.FindStudensByClassName((string)comboBoxClass.SelectedItem).ToList();
            dataGridView1.Rows.Clear();
            for (int i = 2; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns.RemoveAt(i);
            }

            foreach (var student in students)
            {
                dataGridView1.Rows.Add(student.ID, student.Surname + " " + student.Name + " " + student.Patronymic);
            }

            foreach (var student in students)
            {
                List<int> marks = student.Marks[(string)comboBoxLesson.SelectedItem];
                for (int i = 0; i < marks.Count; i++)
                {
                    DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                    column.HeaderText = $"Занятие №{i+1}";
                    column.Items.Add("н");
                    column.Items.Add("-");
                    column.Items.Add("2");
                    column.Items.Add("3");
                    column.Items.Add("4");
                    column.Items.Add("5");
                    dataGridView1.Columns.Add(column);
                    dataGridView1.Rows[i].Cells[i+2].Value = marks[i];
                }
            }
        }

        private void addLesson_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.HeaderText = $"Занятие";
            column.Items.Add("н");
            column.Items.Add("-");
            column.Items.Add("2");
            column.Items.Add("3");
            column.Items.Add("4");
            column.Items.Add("5");
            dataGridView1.Columns.Add(column);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
