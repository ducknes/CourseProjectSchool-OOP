namespace CourseProjectSchool.UI
{
    partial class viewStudentMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewStudentMarks));
            dataGridView1=new DataGridView();
            Column1=new DataGridViewTextBoxColumn();
            Column2=new DataGridViewTextBoxColumn();
            name=new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows=false;
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Dock=DockStyle.Bottom;
            dataGridView1.Location=new Point(0, 36);
            dataGridView1.Margin=new Padding(3, 2, 3, 2);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersVisible=false;
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=29;
            dataGridView1.Size=new Size(507, 308);
            dataGridView1.TabIndex=0;
            // 
            // Column1
            // 
            Column1.HeaderText="Предмет";
            Column1.MinimumWidth=6;
            Column1.Name="Column1";
            // 
            // Column2
            // 
            Column2.HeaderText="Оценки";
            Column2.MinimumWidth=6;
            Column2.Name="Column2";
            // 
            // name
            // 
            name.AutoSize=true;
            name.Font=new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location=new Point(102, 7);
            name.Name="name";
            name.Size=new Size(0, 21);
            name.TabIndex=1;
            name.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // viewStudentMarks
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(507, 344);
            Controls.Add(name);
            Controls.Add(dataGridView1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(3, 2, 3, 2);
            Name="viewStudentMarks";
            Text="Оценки ученика";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        public Label name;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}