namespace CourseProjectSchoool
{
    partial class StudentRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecord));
            dataGridView1=new DataGridView();
            Column1=new DataGridViewTextBoxColumn();
            Column2=new DataGridViewTextBoxColumn();
            Column3=new DataGridViewTextBoxColumn();
            Column4=new DataGridViewTextBoxColumn();
            addStudent=new Button();
            editStudent=new Button();
            sortViaAlfabet=new Button();
            findBySurname=new Button();
            filterBy=new Button();
            textBox1=new TextBox();
            comboBox1=new ComboBox();
            label1=new Label();
            surnameTB=new TextBox();
            nameTB=new TextBox();
            label2=new Label();
            patronymicTB=new TextBox();
            label3=new Label();
            classTB=new TextBox();
            label4=new Label();
            avgAttTB=new TextBox();
            label5=new Label();
            avgPerfTB=new TextBox();
            label6=new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns=false;
            dataGridView1.AllowUserToResizeRows=false;
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location=new Point(15, 15);
            dataGridView1.Margin=new Padding(4, 3, 4, 3);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersVisible=false;
            dataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size=new Size(904, 384);
            dataGridView1.TabIndex=0;
            // 
            // Column1
            // 
            Column1.HeaderText="ФИО";
            Column1.Name="Column1";
            // 
            // Column2
            // 
            Column2.HeaderText="Класс";
            Column2.Name="Column2";
            // 
            // Column3
            // 
            Column3.HeaderText="Средняя успеваемость";
            Column3.Name="Column3";
            // 
            // Column4
            // 
            Column4.HeaderText="Средняя посещаемость";
            Column4.Name="Column4";
            // 
            // addStudent
            // 
            addStudent.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addStudent.Location=new Point(977, 292);
            addStudent.Margin=new Padding(4, 3, 4, 3);
            addStudent.Name="addStudent";
            addStudent.Size=new Size(173, 31);
            addStudent.TabIndex=1;
            addStudent.Text="Добавить ученика";
            addStudent.UseVisualStyleBackColor=true;
            addStudent.Click+=addStudent_Click;
            // 
            // editStudent
            // 
            editStudent.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            editStudent.Location=new Point(149, 424);
            editStudent.Margin=new Padding(4, 3, 4, 3);
            editStudent.Name="editStudent";
            editStudent.Size=new Size(217, 31);
            editStudent.TabIndex=3;
            editStudent.Text="Редактировать класс";
            editStudent.UseVisualStyleBackColor=true;
            // 
            // sortViaAlfabet
            // 
            sortViaAlfabet.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sortViaAlfabet.Location=new Point(149, 462);
            sortViaAlfabet.Margin=new Padding(4, 3, 4, 3);
            sortViaAlfabet.Name="sortViaAlfabet";
            sortViaAlfabet.Size=new Size(217, 31);
            sortViaAlfabet.TabIndex=4;
            sortViaAlfabet.Text="Сортировать по алфавиту";
            sortViaAlfabet.UseVisualStyleBackColor=true;
            // 
            // findBySurname
            // 
            findBySurname.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            findBySurname.Location=new Point(402, 424);
            findBySurname.Margin=new Padding(4, 3, 4, 3);
            findBySurname.Name="findBySurname";
            findBySurname.Size=new Size(217, 31);
            findBySurname.TabIndex=5;
            findBySurname.Text="Поиск по фамилии";
            findBySurname.UseVisualStyleBackColor=true;
            // 
            // filterBy
            // 
            filterBy.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterBy.Location=new Point(402, 462);
            filterBy.Margin=new Padding(4, 3, 4, 3);
            filterBy.Name="filterBy";
            filterBy.Size=new Size(217, 31);
            filterBy.TabIndex=6;
            filterBy.Text="Отфильтровать по ";
            filterBy.UseVisualStyleBackColor=true;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(643, 428);
            textBox1.Margin=new Padding(4, 3, 4, 3);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(140, 23);
            textBox1.TabIndex=7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(643, 465);
            comboBox1.Margin=new Padding(4, 3, 4, 3);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(140, 23);
            comboBox1.TabIndex=8;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(926, 109);
            label1.Name="label1";
            label1.Size=new Size(64, 18);
            label1.TabIndex=9;
            label1.Text="Фамилия";
            // 
            // surnameTB
            // 
            surnameTB.Location=new Point(1101, 104);
            surnameTB.Name="surnameTB";
            surnameTB.Size=new Size(100, 23);
            surnameTB.TabIndex=10;
            // 
            // nameTB
            // 
            nameTB.Location=new Point(1101, 133);
            nameTB.Name="nameTB";
            nameTB.Size=new Size(100, 23);
            nameTB.TabIndex=12;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(926, 138);
            label2.Name="label2";
            label2.Size=new Size(32, 18);
            label2.TabIndex=11;
            label2.Text="Имя";
            // 
            // patronymicTB
            // 
            patronymicTB.Location=new Point(1101, 162);
            patronymicTB.Name="patronymicTB";
            patronymicTB.Size=new Size(100, 23);
            patronymicTB.TabIndex=14;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(926, 167);
            label3.Name="label3";
            label3.Size=new Size(72, 18);
            label3.TabIndex=13;
            label3.Text="Отчество";
            // 
            // classTB
            // 
            classTB.Location=new Point(1101, 191);
            classTB.Name="classTB";
            classTB.Size=new Size(100, 23);
            classTB.TabIndex=16;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(926, 196);
            label4.Name="label4";
            label4.Size=new Size(48, 18);
            label4.TabIndex=15;
            label4.Text="Класс";
            // 
            // avgAttTB
            // 
            avgAttTB.Location=new Point(1101, 249);
            avgAttTB.Name="avgAttTB";
            avgAttTB.Size=new Size(100, 23);
            avgAttTB.TabIndex=20;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location=new Point(926, 254);
            label5.Name="label5";
            label5.Size=new Size(168, 18);
            label5.TabIndex=19;
            label5.Text="Средняя посещаемость";
            // 
            // avgPerfTB
            // 
            avgPerfTB.Location=new Point(1101, 220);
            avgPerfTB.Name="avgPerfTB";
            avgPerfTB.Size=new Size(100, 23);
            avgPerfTB.TabIndex=18;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location=new Point(926, 225);
            label6.Name="label6";
            label6.Size=new Size(176, 18);
            label6.TabIndex=17;
            label6.Text="Среднняя успеваемость";
            // 
            // StudentRecord
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(1213, 519);
            Controls.Add(avgAttTB);
            Controls.Add(label5);
            Controls.Add(avgPerfTB);
            Controls.Add(label6);
            Controls.Add(classTB);
            Controls.Add(label4);
            Controls.Add(patronymicTB);
            Controls.Add(label3);
            Controls.Add(nameTB);
            Controls.Add(label2);
            Controls.Add(surnameTB);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(filterBy);
            Controls.Add(findBySurname);
            Controls.Add(sortViaAlfabet);
            Controls.Add(editStudent);
            Controls.Add(addStudent);
            Controls.Add(dataGridView1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(4, 3, 4, 3);
            Name="StudentRecord";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Учет студентов";
            FormClosing+=StudentRecord_FormClosing;
            Load+=StudentRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button editStudent;
        private System.Windows.Forms.Button sortViaAlfabet;
        private System.Windows.Forms.Button findBySurname;
        private System.Windows.Forms.Button filterBy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Label label1;
        private TextBox surnameTB;
        private TextBox nameTB;
        private Label label2;
        private TextBox patronymicTB;
        private Label label3;
        private TextBox classTB;
        private Label label4;
        private TextBox avgAttTB;
        private Label label5;
        private TextBox avgPerfTB;
        private Label label6;
    }
}