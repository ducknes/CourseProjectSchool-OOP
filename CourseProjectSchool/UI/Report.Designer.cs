﻿namespace CourseProjectSchool.UI
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            richTextBox1=new RichTextBox();
            saveReport=new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location=new Point(12, 12);
            richTextBox1.Name="richTextBox1";
            richTextBox1.Size=new Size(501, 557);
            richTextBox1.TabIndex=0;
            richTextBox1.Text="";
            richTextBox1.TextChanged+=richTextBox1_TextChanged;
            // 
            // saveReport
            // 
            saveReport.Font=new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveReport.Location=new Point(163, 574);
            saveReport.Name="saveReport";
            saveReport.Size=new Size(198, 34);
            saveReport.TabIndex=1;
            saveReport.Text="Сохранить отчет";
            saveReport.UseVisualStyleBackColor=true;
            saveReport.Click+=saveReport_Click;
            // 
            // Report
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(525, 616);
            Controls.Add(saveReport);
            Controls.Add(richTextBox1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="Report";
            Text="Отчет";
            Load+=Report_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button saveReport;
    }
}