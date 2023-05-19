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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecord));
            dataGridView1=new DataGridView();
            Column6=new DataGridViewTextBoxColumn();
            Column1=new DataGridViewTextBoxColumn();
            Column2=new DataGridViewTextBoxColumn();
            Column5=new DataGridViewButtonColumn();
            Column3=new DataGridViewTextBoxColumn();
            Column4=new DataGridViewTextBoxColumn();
            contextMenuStrip1=new ContextMenuStrip(components);
            удалитьУченикаToolStripMenuItem=new ToolStripMenuItem();
            addStudent=new Button();
            sortViaAlfabet=new Button();
            filterBy=new Button();
            find=new TextBox();
            comboBox1=new ComboBox();
            label1=new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows=false;
            dataGridView1.AllowUserToResizeColumns=false;
            dataGridView1.AllowUserToResizeRows=false;
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column5, Column3, Column4 });
            dataGridView1.ContextMenuStrip=contextMenuStrip1;
            dataGridView1.Location=new Point(15, 15);
            dataGridView1.Margin=new Padding(4, 3, 4, 3);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size=new Size(904, 384);
            dataGridView1.TabIndex=0;
            dataGridView1.RowHeaderMouseDoubleClick+=dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // Column6
            // 
            Column6.HeaderText="ID";
            Column6.Name="Column6";
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
            // Column5
            // 
            Column5.HeaderText="Просмотр успеваемости";
            Column5.Name="Column5";
            Column5.Resizable=DataGridViewTriState.True;
            Column5.SortMode=DataGridViewColumnSortMode.Automatic;
            Column5.Text="Посмотреть";
            Column5.UseColumnTextForButtonValue=true;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьУченикаToolStripMenuItem });
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(167, 26);
            // 
            // удалитьУченикаToolStripMenuItem
            // 
            удалитьУченикаToolStripMenuItem.Name="удалитьУченикаToolStripMenuItem";
            удалитьУченикаToolStripMenuItem.Size=new Size(166, 22);
            удалитьУченикаToolStripMenuItem.Text="Удалить ученика";
            удалитьУченикаToolStripMenuItem.Click+=удалитьУченикаToolStripMenuItem_Click;
            // 
            // addStudent
            // 
            addStudent.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addStudent.Location=new Point(957, 60);
            addStudent.Margin=new Padding(4, 3, 4, 3);
            addStudent.Name="addStudent";
            addStudent.Size=new Size(173, 31);
            addStudent.TabIndex=1;
            addStudent.Text="Добавить ученика";
            addStudent.UseVisualStyleBackColor=true;
            addStudent.Click+=addStudent_Click;
            // 
            // sortViaAlfabet
            // 
            sortViaAlfabet.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sortViaAlfabet.Location=new Point(935, 97);
            sortViaAlfabet.Margin=new Padding(4, 3, 4, 3);
            sortViaAlfabet.Name="sortViaAlfabet";
            sortViaAlfabet.Size=new Size(217, 31);
            sortViaAlfabet.TabIndex=4;
            sortViaAlfabet.Text="Сортировать по алфавиту";
            sortViaAlfabet.UseVisualStyleBackColor=true;
            // 
            // filterBy
            // 
            filterBy.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterBy.Location=new Point(935, 291);
            filterBy.Margin=new Padding(4, 3, 4, 3);
            filterBy.Name="filterBy";
            filterBy.Size=new Size(217, 31);
            filterBy.TabIndex=6;
            filterBy.Text="Отфильтровать по ";
            filterBy.UseVisualStyleBackColor=true;
            // 
            // find
            // 
            find.Location=new Point(935, 209);
            find.Margin=new Padding(4, 3, 4, 3);
            find.Name="find";
            find.Size=new Size(217, 23);
            find.TabIndex=7;
            find.TextAlign=HorizontalAlignment.Center;
            find.TextChanged+=textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(973, 328);
            comboBox1.Margin=new Padding(4, 3, 4, 3);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(140, 23);
            comboBox1.TabIndex=8;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(966, 185);
            label1.Name="label1";
            label1.Size=new Size(154, 21);
            label1.TabIndex=9;
            label1.Text="Поиск по фамилии";
            // 
            // StudentRecord
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(1168, 421);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(find);
            Controls.Add(filterBy);
            Controls.Add(sortViaAlfabet);
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
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addStudent;
        private Button sortViaAlfabet;
        private Button filterBy;
        private TextBox find;
        private ComboBox comboBox1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьУченикаToolStripMenuItem;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}