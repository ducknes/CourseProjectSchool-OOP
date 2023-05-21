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

        public delegate void UpdateDelegate();
        public event UpdateDelegate UpdateClassesTableEvent;

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
            if (students.Count == 0)
            {
                return;
            }
            dataGridView1.Rows.Clear();
            int countColumns = dataGridView1.ColumnCount - 2;
            for (int i = 0; i < countColumns; i++)
            {
                dataGridView1.Columns.RemoveAt(2);
            }
            dataGridView1.Refresh();

            foreach (var student in students)
            {
                dataGridView1.Rows.Add(student.ID, student.Surname + " " + student.Name + " " + student.Patronymic);
            }

            int countLessons = students[0].Marks[(string)comboBoxLesson.SelectedItem].Count;

            for (int i = 0; i < countLessons; i++)
            {
                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                column.HeaderText = $"Занятие №{i + 1}";
                column.Items.Add("н");
                column.Items.Add("-");
                column.Items.Add("2");
                column.Items.Add("3");
                column.Items.Add("4");
                column.Items.Add("5");
                dataGridView1.Columns.Add(column);
            }

            int row = 0;
            foreach (var student in students)
            {
                List<int> marks = student.Marks[(string)comboBoxLesson.SelectedItem];

                for (int i = 0; i < marks.Count; i++)
                {
                    int mark = marks[i];
                    switch (mark)
                    {
                        case 0:
                            dataGridView1.Rows[row].Cells[i + 2].Value = "н";
                            break;
                        case 1:
                            dataGridView1.Rows[row].Cells[i + 2].Value = "-";
                            break;
                        default:
                            dataGridView1.Rows[row].Cells[i + 2].Value = mark.ToString();
                            break;
                    }

                }
                row++;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            List<Student> students = Repository.FindStudensByClassName((string)comboBoxClass.SelectedItem).ToList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                foreach (var student in students)
                {
                    if (student.ID == (Guid)dataGridView1.Rows[i].Cells[0].Value)
                    {
                        List<int> list = new List<int>();
                        for (int j = 2; j < dataGridView1.ColumnCount; j++)
                        {
                            string value = (string)dataGridView1.Rows[i].Cells[j].Value;
                            switch (value)
                            {
                                case "н":
                                    list.Add(0);
                                    break;
                                case "":
                                    list.Add(1);
                                    break;
                                case "-":
                                    list.Add(1);
                                    break;
                                default:
                                    list.Add(int.Parse(value));
                                    break;
                            }
                        }
                        student.Marks[(string)comboBoxLesson.SelectedItem] = list;
                        float _ = Repository.GetAverageStudentPerformance(student.ID);
                        float __ = Repository.CountAverageAttendance(student.ID);
                        UpdateClassesTableEvent?.Invoke();
                    }
                }
            }
        }

        private void SetMarks_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateClassesTableEvent?.Invoke();
        }
    }
}
