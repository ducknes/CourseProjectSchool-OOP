namespace CourseProjectSchoool
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            label1=new Label();
            button1=new Button();
            button2=new Button();
            button3=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(236, 132);
            label1.Margin=new Padding(4, 0, 4, 0);
            label1.Name="label1";
            label1.Size=new Size(156, 28);
            label1.TabIndex=0;
            label1.Text="Главное меню";
            // 
            // button1
            // 
            button1.Font=new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(187, 167);
            button1.Margin=new Padding(4, 3, 4, 3);
            button1.Name="button1";
            button1.Size=new Size(266, 36);
            button1.TabIndex=1;
            button1.Text="Учет классов";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Font=new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location=new Point(187, 210);
            button2.Margin=new Padding(4, 3, 4, 3);
            button2.Name="button2";
            button2.Size=new Size(266, 36);
            button2.TabIndex=2;
            button2.Text="Учет учеников";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Font=new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location=new Point(187, 253);
            button3.Margin=new Padding(4, 3, 4, 3);
            button3.Name="button3";
            button3.Size=new Size(266, 63);
            button3.TabIndex=3;
            button3.Text="Генерация отчета о успеваемости учеников";
            button3.UseVisualStyleBackColor=true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(667, 420);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(4, 3, 4, 3);
            Name="MainMenu";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Главное меню";
            FormClosing+=MainMenu_FormClosing;
            Load+=MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}