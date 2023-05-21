namespace CourseProjectSchool.UI
{
    partial class SetMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetMarks));
            label1=new Label();
            label2=new Label();
            comboBoxClass=new ComboBox();
            comboBoxLesson=new ComboBox();
            dataGridView1=new DataGridView();
            ID=new DataGridViewTextBoxColumn();
            Column1=new DataGridViewTextBoxColumn();
            findMarks=new Button();
            addLesson=new Button();
            button1=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(10, 15);
            label1.Name="label1";
            label1.Size=new Size(120, 17);
            label1.TabIndex=0;
            label1.Text="Выберете класс";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(263, 16);
            label2.Name="label2";
            label2.Size=new Size(136, 17);
            label2.TabIndex=1;
            label2.Text="Выберете предмет";
            label2.Click+=label2_Click;
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled=true;
            comboBoxClass.Location=new Point(136, 13);
            comboBoxClass.Name="comboBoxClass";
            comboBoxClass.Size=new Size(121, 23);
            comboBoxClass.TabIndex=2;
            comboBoxClass.SelectedIndexChanged+=comboBoxClass_SelectedIndexChanged;
            // 
            // comboBoxLesson
            // 
            comboBoxLesson.FormattingEnabled=true;
            comboBoxLesson.Location=new Point(405, 13);
            comboBoxLesson.Name="comboBoxLesson";
            comboBoxLesson.Size=new Size(121, 23);
            comboBoxLesson.TabIndex=3;
            comboBoxLesson.SelectedIndexChanged+=comboBoxLesson_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows=false;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Column1 });
            dataGridView1.Location=new Point(-1, 46);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersVisible=false;
            dataGridView1.RowTemplate.Height=25;
            dataGridView1.Size=new Size(804, 367);
            dataGridView1.TabIndex=4;
            dataGridView1.CellContentClick+=dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText="ID";
            ID.Name="ID";
            // 
            // Column1
            // 
            Column1.HeaderText="Ученик";
            Column1.Name="Column1";
            // 
            // findMarks
            // 
            findMarks.Font=new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            findMarks.Location=new Point(542, 11);
            findMarks.Name="findMarks";
            findMarks.Size=new Size(87, 26);
            findMarks.TabIndex=5;
            findMarks.Text="Найти";
            findMarks.UseVisualStyleBackColor=true;
            findMarks.Click+=findMarks_Click;
            // 
            // addLesson
            // 
            addLesson.Font=new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addLesson.Location=new Point(656, 11);
            addLesson.Name="addLesson";
            addLesson.Size=new Size(130, 26);
            addLesson.TabIndex=6;
            addLesson.Text="Добавить урок";
            addLesson.UseVisualStyleBackColor=true;
            addLesson.Click+=addLesson_Click;
            // 
            // button1
            // 
            button1.BackColor=Color.FromArgb(128, 255, 128);
            button1.Font=new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(-1, 410);
            button1.Name="button1";
            button1.Size=new Size(804, 37);
            button1.TabIndex=7;
            button1.Text="Сохранить";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // SetMarks
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(800, 446);
            Controls.Add(button1);
            Controls.Add(addLesson);
            Controls.Add(findMarks);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxLesson);
            Controls.Add(comboBoxClass);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="SetMarks";
            Text="Выставление оценок";
            FormClosing+=SetMarks_FormClosing;
            Load+=SetMarks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxClass;
        private ComboBox comboBoxLesson;
        private DataGridView dataGridView1;
        private Button findMarks;
        private Button addLesson;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
    }
}