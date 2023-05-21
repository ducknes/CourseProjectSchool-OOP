using CourseProjectSchool.DB;
using CourseProjectSchool.Models;
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
    public partial class СlassRecord : Form
    {


        public СlassRecord()
        {
            InitializeComponent();
        }

        private void addClass_Click(object sender, EventArgs e)
        {
            AddClass add = new AddClass();
            add.UpdateClassesTableEvent += UpdateTable;
            add.Show();
        }

        private void СlassRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                List<SchoolClass> list = Repository.FindClassesByName(textBox1.Text).ToList();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                int iterator = 0;
                foreach (var item in list)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[iterator].Cells[0].Value = item.ID;
                    dataGridView1.Rows[iterator].Cells[1].Value = item.Name;
                    dataGridView1.Rows[iterator].Cells[2].Value = Repository.CountStudents(item.Name);
                    dataGridView1.Rows[iterator].Cells[4].Value = Repository.GetAverageClassPerformance(item.ID);
                    dataGridView1.Rows[iterator].Cells[5].Value = Repository.GetAverageClassAttendance(item.ID);
                    iterator++;
                }
            }
            else
            {
                UpdateTable();
            }


        }

        private void СlassRecord_Load(object sender, EventArgs e)
        {
            UpdateTable();
            comboBox1.Items.Add("Успеваемость > 4.5");
            comboBox1.Items.Add("Помещаемость > 85");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                EditClass editClass = new EditClass();
                editClass.UpdateClassesTableEvent += UpdateTable;
                editClass.editClassName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                SchoolClass sc = Repository.FindClassByName(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                editClass.ClassID.Text = sc.ID.ToString();
                editClass.Show();
            }
        }
        public void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            int iterator = 0;
            foreach (var item in Repository.Classes)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[iterator].Cells[0].Value = item.ID;
                dataGridView1.Rows[iterator].Cells[1].Value = item.Name;
                dataGridView1.Rows[iterator].Cells[2].Value = Repository.CountStudents(item.Name);
                dataGridView1.Rows[iterator].Cells[4].Value = Repository.GetAverageClassPerformance(item.ID);
                dataGridView1.Rows[iterator].Cells[5].Value = Repository.GetAverageClassAttendance(item.ID);
                iterator++;
            }
        }

        private void удалитьКлассToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
            if (MessageBox.Show("Вы хотите удалить класс?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Repository.DeleteClass((string)dataGridViewRow.Cells[1].Value);
                UpdateTable();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                List<Student> students = Repository.FindStudensByClassName((string)dataGridView1.Rows[e.RowIndex].Cells[1].Value).ToList();
                ViewClassStudents viewClassStudents = new ViewClassStudents();
                int iterator = 0;
                foreach (Student student in students)
                {
                    viewClassStudents.dataGridView1.Rows.Add();
                    viewClassStudents.dataGridView1.Rows[iterator].Cells[0].Value = student.ID;
                    viewClassStudents.dataGridView1.Rows[iterator].Cells[1].Value = student.Surname + " " + student.Name + " " + student.Patronymic;
                    iterator++;
                }
                viewClassStudents.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetMarks setMarks = new();
            setMarks.Show();
        }

        private void sortViaPerformance_Click(object sender, EventArgs e)
        {
            List<SchoolClass> schoolClasses = Repository.GetSortedClasses().ToList();
            dataGridView1.Rows.Clear();
            int iterator = 0;
            foreach (var item in schoolClasses)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[iterator].Cells[0].Value = item.ID;
                dataGridView1.Rows[iterator].Cells[1].Value = item.Name;
                dataGridView1.Rows[iterator].Cells[2].Value = Repository.CountStudents(item.Name);
                dataGridView1.Rows[iterator].Cells[4].Value = Repository.GetAverageClassPerformance(item.ID);
                dataGridView1.Rows[iterator].Cells[5].Value = Repository.GetAverageClassAttendance(item.ID);
                iterator++;
            }
        }
    }
}
