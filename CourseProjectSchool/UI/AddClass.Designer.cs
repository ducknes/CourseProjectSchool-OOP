namespace CourseProjectSchool.UI
{
    partial class AddClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClass));
            saveNewClass=new Button();
            label1=new Label();
            newClassName=new TextBox();
            SuspendLayout();
            // 
            // saveNewClass
            // 
            saveNewClass.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveNewClass.Location=new Point(107, 128);
            saveNewClass.Name="saveNewClass";
            saveNewClass.Size=new Size(126, 27);
            saveNewClass.TabIndex=0;
            saveNewClass.Text="Сохранить";
            saveNewClass.UseVisualStyleBackColor=true;
            saveNewClass.Click+=saveNewClass_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(84, 75);
            label1.Name="label1";
            label1.Size=new Size(172, 21);
            label1.TabIndex=1;
            label1.Text="Введите имя класса";
            // 
            // newClassName
            // 
            newClassName.Location=new Point(65, 99);
            newClassName.Name="newClassName";
            newClassName.Size=new Size(210, 23);
            newClassName.TabIndex=2;
            // 
            // AddClass
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(361, 243);
            Controls.Add(newClassName);
            Controls.Add(label1);
            Controls.Add(saveNewClass);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="AddClass";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Добавление нового класса";
            FormClosing+=AddClass_FormClosing;
            Load+=AddClass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveNewClass;
        private Label label1;
        private TextBox newClassName;
    }
}