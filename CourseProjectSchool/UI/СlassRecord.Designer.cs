namespace CourseProjectSchoool
{
    partial class СlassRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(СlassRecord));
            comboBox1=new ComboBox();
            textBox1=new TextBox();
            filterBy=new Button();
            findByName=new Button();
            sortViaPerformance=new Button();
            editClass=new Button();
            deleteClass=new Button();
            addClass=new Button();
            dataGridView1=new DataGridView();
            Column1=new DataGridViewTextBoxColumn();
            Column2=new DataGridViewTextBoxColumn();
            Column5=new DataGridViewTextBoxColumn();
            Column3=new DataGridViewTextBoxColumn();
            Column4=new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(712, 472);
            comboBox1.Margin=new Padding(4, 3, 4, 3);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(140, 23);
            comboBox1.TabIndex=17;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(712, 435);
            textBox1.Margin=new Padding(4, 3, 4, 3);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(140, 23);
            textBox1.TabIndex=16;
            // 
            // filterBy
            // 
            filterBy.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterBy.Location=new Point(471, 468);
            filterBy.Margin=new Padding(4, 3, 4, 3);
            filterBy.Name="filterBy";
            filterBy.Size=new Size(217, 31);
            filterBy.TabIndex=15;
            filterBy.Text="Отфильтровать по ";
            filterBy.UseVisualStyleBackColor=true;
            // 
            // findByName
            // 
            findByName.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            findByName.Location=new Point(471, 430);
            findByName.Margin=new Padding(4, 3, 4, 3);
            findByName.Name="findByName";
            findByName.Size=new Size(217, 31);
            findByName.TabIndex=14;
            findByName.Text="Поиск по назаванию";
            findByName.UseVisualStyleBackColor=true;
            // 
            // sortViaPerformance
            // 
            sortViaPerformance.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sortViaPerformance.Location=new Point(206, 467);
            sortViaPerformance.Margin=new Padding(4, 3, 4, 3);
            sortViaPerformance.Name="sortViaPerformance";
            sortViaPerformance.Size=new Size(246, 31);
            sortViaPerformance.TabIndex=13;
            sortViaPerformance.Text="Сортировать по возрастанию";
            sortViaPerformance.UseVisualStyleBackColor=true;
            // 
            // editClass
            // 
            editClass.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            editClass.Location=new Point(218, 430);
            editClass.Margin=new Padding(4, 3, 4, 3);
            editClass.Name="editClass";
            editClass.Size=new Size(217, 31);
            editClass.TabIndex=12;
            editClass.Text="Редактировать класс";
            editClass.UseVisualStyleBackColor=true;
            // 
            // deleteClass
            // 
            deleteClass.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deleteClass.Location=new Point(16, 468);
            deleteClass.Margin=new Padding(4, 3, 4, 3);
            deleteClass.Name="deleteClass";
            deleteClass.Size=new Size(173, 31);
            deleteClass.TabIndex=11;
            deleteClass.Text="Удалить класс";
            deleteClass.UseVisualStyleBackColor=true;
            // 
            // addClass
            // 
            addClass.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addClass.Location=new Point(15, 430);
            addClass.Margin=new Padding(4, 3, 4, 3);
            addClass.Name="addClass";
            addClass.Size=new Size(173, 31);
            addClass.TabIndex=10;
            addClass.Text="Добавить класс";
            addClass.UseVisualStyleBackColor=true;
            addClass.Click+=addClass_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns=false;
            dataGridView1.AllowUserToResizeRows=false;
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column4 });
            dataGridView1.Location=new Point(15, 21);
            dataGridView1.Margin=new Padding(4, 3, 4, 3);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersVisible=false;
            dataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size=new Size(904, 384);
            dataGridView1.TabIndex=9;
            // 
            // Column1
            // 
            Column1.HeaderText="Класс";
            Column1.Name="Column1";
            // 
            // Column2
            // 
            Column2.HeaderText="Количество учеников";
            Column2.Name="Column2";
            // 
            // Column5
            // 
            Column5.HeaderText="Список учеников";
            Column5.Name="Column5";
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
            // СlassRecord
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(933, 519);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(filterBy);
            Controls.Add(findByName);
            Controls.Add(sortViaPerformance);
            Controls.Add(editClass);
            Controls.Add(deleteClass);
            Controls.Add(addClass);
            Controls.Add(dataGridView1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(4, 3, 4, 3);
            Name="СlassRecord";
            StartPosition=FormStartPosition.CenterScreen;
            Text="СlassRecord";
            FormClosing+=СlassRecord_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button filterBy;
        private System.Windows.Forms.Button findByName;
        private System.Windows.Forms.Button sortViaPerformance;
        private System.Windows.Forms.Button editClass;
        private System.Windows.Forms.Button deleteClass;
        private System.Windows.Forms.Button addClass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}