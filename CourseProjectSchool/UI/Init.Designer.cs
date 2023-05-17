namespace CourseProjectSchoool
{
    partial class Init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            imageList1=new ImageList(components);
            pictureBox1=new PictureBox();
            label1=new Label();
            button1=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth=ColorDepth.Depth8Bit;
            imageList1.ImageStream=(ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor=Color.Transparent;
            imageList1.Images.SetKeyName(0, "school-svgrepo-com.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor=AnchorStyles.None;
            pictureBox1.Image=CourseProjectSchool.Properties.Resources.school_svgrepo_com__1_;
            pictureBox1.Location=new Point(34, 60);
            pictureBox1.Margin=new Padding(4, 3, 4, 3);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(256, 256);
            pictureBox1.SizeMode=PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.Anchor=AnchorStyles.None;
            label1.AutoSize=true;
            label1.Font=new Font("Cascadia Code", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(298, 108);
            label1.Margin=new Padding(4, 0, 4, 0);
            label1.Name="label1";
            label1.Size=new Size(549, 48);
            label1.TabIndex=1;
            label1.Text="Курсовая работа студента гр. 21ВП2 Антонова Ильи \r\nна тему \"Школа\"";
            label1.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor=AnchorStyles.None;
            button1.Font=new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(401, 198);
            button1.Margin=new Padding(4, 3, 4, 3);
            button1.Name="button1";
            button1.Size=new Size(345, 58);
            button1.TabIndex=2;
            button1.Text="Управление школой";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // Init
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(933, 404);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(4, 3, 4, 3);
            Name="Init";
            StartPosition=FormStartPosition.CenterScreen;
            Text="ИС \"Школа\"";
            Load+=Init_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

