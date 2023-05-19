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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseProjectSchoool
{
    public partial class StudentRecord : Form
    {
        public StudentRecord()
        {
            InitializeComponent();
        }

        private void StudentRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.UpdateClassesTableEvent += UpdateTable;
            addStudent.Show();
        }

        private void удалитьУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
            if (MessageBox.Show("Вы хотите удалить класс?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Repository.DeleteStudent((Guid)dataGridViewRow.Cells[0].Value);
                UpdateTable();
            }
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            int iterator = 0;
            foreach (var item in Repository.Students)
            {
                string studentFIO = item.Surname + " " + item.Name + " " + item.Patronymic;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[iterator].Cells[0].Value = item.ID;
                dataGridView1.Rows[iterator].Cells[1].Value = studentFIO;
                dataGridView1.Rows[iterator].Cells[2].Value = item.ClassName;
                iterator++;
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
            string[] fio = dataGridViewRow.Cells[1].Value.ToString().Split(" ");
            EditStudent editStudent = new EditStudent();
            editStudent.UpdateClassesTableEvent += UpdateTable;
            editStudent.id.Text = dataGridViewRow.Cells[0].Value.ToString();
            editStudent.surnameTB.Text = fio[0];
            editStudent.nameTB.Text = fio[1];
            editStudent.patronymicTB.Text = fio[2];
            foreach (var item in Repository.Classes)
            {
                editStudent.comboBox2.Items.Add(item.Name);
            }
            editStudent.comboBox2.SelectedItem = (string)dataGridViewRow.Cells[2].Value;
            editStudent.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (find.Text != string.Empty)
            {
                List<Student> students = Repository.FindStudenstsBySurname(find.Text).ToList();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                int iterator = 0;
                foreach (var item in students)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[iterator].Cells[0].Value = item.ID;
                    dataGridView1.Rows[iterator].Cells[1].Value = item.Surname + " " + item.Name + " " + item.Patronymic;
                    dataGridView1.Rows[iterator].Cells[2].Value = item.ClassName;
                    iterator++;
                }
            }
            else
            {
                UpdateTable();
            }
        }
    }
}
