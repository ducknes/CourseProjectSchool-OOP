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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(СlassRecord));
            comboBox1=new ComboBox();
            textBox1=new TextBox();
            filterBy=new Button();
            sortViaPerformance=new Button();
            addClass=new Button();
            dataGridView1=new DataGridView();
            Column6=new DataGridViewTextBoxColumn();
            Column1=new DataGridViewTextBoxColumn();
            Column2=new DataGridViewTextBoxColumn();
            Column5=new DataGridViewButtonColumn();
            Column3=new DataGridViewTextBoxColumn();
            Column4=new DataGridViewTextBoxColumn();
            contextMenuStrip1=new ContextMenuStrip(components);
            удалитьКлассToolStripMenuItem=new ToolStripMenuItem();
            label1=new Label();
            button1=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(968, 355);
            comboBox1.Margin=new Padding(4, 3, 4, 3);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(140, 23);
            comboBox1.TabIndex=17;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(934, 216);
            textBox1.Margin=new Padding(4, 3, 4, 3);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(209, 23);
            textBox1.TabIndex=16;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // filterBy
            // 
            filterBy.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterBy.Location=new Point(934, 318);
            filterBy.Margin=new Padding(4, 3, 4, 3);
            filterBy.Name="filterBy";
            filterBy.Size=new Size(209, 31);
            filterBy.TabIndex=15;
            filterBy.Text="Отфильтровать по ";
            filterBy.UseVisualStyleBackColor=true;
            // 
            // sortViaPerformance
            // 
            sortViaPerformance.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sortViaPerformance.Location=new Point(932, 84);
            sortViaPerformance.Margin=new Padding(4, 3, 4, 3);
            sortViaPerformance.Name="sortViaPerformance";
            sortViaPerformance.Size=new Size(209, 31);
            sortViaPerformance.TabIndex=13;
            sortViaPerformance.Text="Сортировать по возрастанию";
            sortViaPerformance.UseVisualStyleBackColor=true;
            // 
            // addClass
            // 
            addClass.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addClass.Location=new Point(951, 47);
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
            dataGridView1.AllowUserToAddRows=false;
            dataGridView1.AllowUserToResizeColumns=false;
            dataGridView1.AllowUserToResizeRows=false;
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column5, Column3, Column4 });
            dataGridView1.ContextMenuStrip=contextMenuStrip1;
            dataGridView1.Location=new Point(15, 21);
            dataGridView1.Margin=new Padding(4, 3, 4, 3);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size=new Size(904, 384);
            dataGridView1.StandardTab=true;
            dataGridView1.TabIndex=9;
            dataGridView1.CellContentClick+=dataGridView1_CellContentClick;
            dataGridView1.CellMouseDoubleClick+=dataGridView1_CellMouseDoubleClick;
            // 
            // Column6
            // 
            Column6.HeaderText="ID";
            Column6.Name="Column6";
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
            Column5.Resizable=DataGridViewTriState.True;
            Column5.SortMode=DataGridViewColumnSortMode.Automatic;
            Column5.Text="Просмотреть";
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
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьКлассToolStripMenuItem });
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(153, 26);
            // 
            // удалитьКлассToolStripMenuItem
            // 
            удалитьКлассToolStripMenuItem.Name="удалитьКлассToolStripMenuItem";
            удалитьКлассToolStripMenuItem.Size=new Size(152, 22);
            удалитьКлассToolStripMenuItem.Text="Удалить класс";
            удалитьКлассToolStripMenuItem.Click+=удалитьКлассToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(964, 195);
            label1.Name="label1";
            label1.Size=new Size(144, 18);
            label1.TabIndex=18;
            label1.Text="Поиск по названию";
            // 
            // button1
            // 
            button1.Font=new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(951, 121);
            button1.Margin=new Padding(4, 3, 4, 3);
            button1.Name="button1";
            button1.Size=new Size(173, 31);
            button1.TabIndex=19;
            button1.Text="Выставить оценки";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // СlassRecord
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(1156, 421);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(filterBy);
            Controls.Add(sortViaPerformance);
            Controls.Add(addClass);
            Controls.Add(dataGridView1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(4, 3, 4, 3);
            Name="СlassRecord";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Учет классов";
            FormClosing+=СlassRecord_FormClosing;
            Load+=СlassRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button filterBy;
        private Button sortViaPerformance;
        private Button addClass;
        private DataGridView dataGridView1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьКлассToolStripMenuItem;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
    }
}