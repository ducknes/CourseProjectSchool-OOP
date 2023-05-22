namespace CourseProjectSchool.UI
{
    partial class EditClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClass));
            editClassName=new TextBox();
            label1=new Label();
            editNewClass=new Button();
            ClassID=new Label();
            SuspendLayout();
            // 
            // editClassName
            // 
            editClassName.Location=new Point(74, 85);
            editClassName.Name="editClassName";
            editClassName.Size=new Size(210, 23);
            editClassName.TabIndex=5;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(93, 61);
            label1.Name="label1";
            label1.Size=new Size(172, 21);
            label1.TabIndex=4;
            label1.Text="Введите имя класса";
            // 
            // editNewClass
            // 
            editNewClass.Font=new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editNewClass.Location=new Point(116, 114);
            editNewClass.Name="editNewClass";
            editNewClass.Size=new Size(126, 27);
            editNewClass.TabIndex=3;
            editNewClass.Text="Сохранить";
            editNewClass.UseVisualStyleBackColor=true;
            editNewClass.Click+=editNewClass_Click;
            // 
            // ClassID
            // 
            ClassID.AutoSize=true;
            ClassID.Location=new Point(160, 31);
            ClassID.Name="ClassID";
            ClassID.Size=new Size(0, 15);
            ClassID.TabIndex=6;
            ClassID.Visible=false;
            // 
            // EditClass
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(361, 205);
            Controls.Add(ClassID);
            Controls.Add(editClassName);
            Controls.Add(label1);
            Controls.Add(editNewClass);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="EditClass";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Редактировать класс";
            Load+=EditClass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button editNewClass;
        public TextBox editClassName;
        public Label ClassID;
    }
}