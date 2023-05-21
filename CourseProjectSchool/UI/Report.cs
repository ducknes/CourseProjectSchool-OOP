using CourseProjectSchool.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectSchool.UI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText(GenerateReport());
        }

        private string GenerateReport()
        {
            StringBuilder report = new StringBuilder();

            foreach (var student in Repository.Students)
            {
                report.Append($"ФИО: {student.Surname} {student.Name} {student.Patronymic} \n");
                report.Append($"Класс: {student.ClassName} \n");
                report.Append($"Средняя успеваемость: {student.AveragePerformance} \n");
                report.Append($"Средняя посещаемость: {student.AverageAttendance} \n");
                report.Append("Список оценок: \n");
                foreach (var item in student.Marks)
                {
                    string marks = item.Key + ": ";
                    foreach (var item2 in item.Value)
                    {
                        switch (item2)
                        {
                            case 0:
                                marks += "н ";
                                break;
                            case 1:
                                marks += "- ";
                                break;
                            default:
                                marks += item2.ToString() + " ";
                                break;
                        }
                    }
                    report.Append("\t" + marks + "\n");
                    marks = string.Empty;
                }
                report.Append("\n\n");
            }
            return report.ToString();
        }

        private void saveReport_Click(object sender, EventArgs e)
        {
            Repository.WriteToReportFile(Repository.REPORT_PATH, GenerateReport());
        }
    }
}
