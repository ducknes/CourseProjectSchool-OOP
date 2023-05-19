namespace CourseProjectSchool.UI
{
    partial class EditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudent));
            button1=new Button();
            comboBox2=new ComboBox();
            label4=new Label();
            patronymicTB=new TextBox();
            label3=new Label();
            nameTB=new TextBox();
            label2=new Label();
            surnameTB=new TextBox();
            label1=new Label();
            saveFileDialog1=new SaveFileDialog();
            id=new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font=new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(118, 160);
            button1.Name="button1";
            button1.Size=new Size(123, 32);
            button1.TabIndex=35;
            button1.Text="Сохранить";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled=true;
            comboBox2.Location=new Point(201, 118);
            comboBox2.Name="comboBox2";
            comboBox2.Size=new Size(121, 23);
            comboBox2.TabIndex=34;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(47, 118);
            label4.Name="label4";
            label4.Size=new Size(48, 18);
            label4.TabIndex=33;
            label4.Text="Класс";
            // 
            // patronymicTB
            // 
            patronymicTB.Location=new Point(201, 84);
            patronymicTB.Name="patronymicTB";
            patronymicTB.Size=new Size(121, 23);
            patronymicTB.TabIndex=32;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(47, 89);
            label3.Name="label3";
            label3.Size=new Size(72, 18);
            label3.TabIndex=31;
            label3.Text="Отчество";
            // 
            // nameTB
            // 
            nameTB.Location=new Point(201, 55);
            nameTB.Name="nameTB";
            nameTB.Size=new Size(121, 23);
            nameTB.TabIndex=30;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(47, 60);
            label2.Name="label2";
            label2.Size=new Size(32, 18);
            label2.TabIndex=29;
            label2.Text="Имя";
            // 
            // surnameTB
            // 
            surnameTB.Location=new Point(201, 26);
            surnameTB.Name="surnameTB";
            surnameTB.Size=new Size(121, 23);
            surnameTB.TabIndex=28;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(47, 31);
            label1.Name="label1";
            label1.Size=new Size(64, 18);
            label1.TabIndex=27;
            label1.Text="Фамилия";
            // 
            // id
            // 
            id.AutoSize=true;
            id.Location=new Point(142, 6);
            id.Name="id";
            id.Size=new Size(0, 15);
            id.TabIndex=36;
            id.Visible=false;
            // 
            // EditStudent
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(367, 214);
            Controls.Add(id);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(patronymicTB);
            Controls.Add(label3);
            Controls.Add(nameTB);
            Controls.Add(label2);
            Controls.Add(surnameTB);
            Controls.Add(label1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="EditStudent";
            StartPosition=FormStartPosition.CenterScreen;
            Text="EditStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public ComboBox comboBox2;
        public Label label4;
        public TextBox patronymicTB;
        public Label label3;
        public TextBox nameTB;
        public Label label2;
        public TextBox surnameTB;
        public Label label1;
        private SaveFileDialog saveFileDialog1;
        public Label id;
    }
}