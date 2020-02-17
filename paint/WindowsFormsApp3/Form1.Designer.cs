namespace WindowsFormsApp3
{
    partial class Form1
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Line = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.rubberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Penbtn = new System.Windows.Forms.Button();
            this.Linebtn = new System.Windows.Forms.Button();
            this.Rectanglebtn = new System.Windows.Forms.Button();
            this.Trianglebtn = new System.Windows.Forms.Button();
            this.Circlebtn = new System.Windows.Forms.Button();
            this.Starbtn = new System.Windows.Forms.Button();
            this.Fillbtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.colorDialog5 = new System.Windows.Forms.ColorDialog();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Line.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(134, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1134, 515);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 52);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Line
            // 
            this.Line.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Line.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.rubberToolStripMenuItem});
            this.Line.Location = new System.Drawing.Point(0, 24);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(1268, 28);
            this.Line.TabIndex = 2;
            this.Line.Text = "Linebtn";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(173, 26);
            this.toolStripMenuItem5.Text = "Save";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(173, 26);
            this.toolStripMenuItem6.Text = "Open";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem2.Text = "Color";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem3.Text = "Clear";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // rubberToolStripMenuItem
            // 
            this.rubberToolStripMenuItem.Name = "rubberToolStripMenuItem";
            this.rubberToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.rubberToolStripMenuItem.Text = "Rubber";
            this.rubberToolStripMenuItem.Click += new System.EventHandler(this.rubberToolStripMenuItem_Click);
            // 
            // Penbtn
            // 
            this.Penbtn.Location = new System.Drawing.Point(21, 78);
            this.Penbtn.Name = "Penbtn";
            this.Penbtn.Size = new System.Drawing.Size(82, 29);
            this.Penbtn.TabIndex = 3;
            this.Penbtn.Text = "Pen";
            this.Penbtn.UseVisualStyleBackColor = true;
            this.Penbtn.Click += new System.EventHandler(this.Penbtn_Click);
            // 
            // Linebtn
            // 
            this.Linebtn.Location = new System.Drawing.Point(21, 125);
            this.Linebtn.Name = "Linebtn";
            this.Linebtn.Size = new System.Drawing.Size(82, 29);
            this.Linebtn.TabIndex = 4;
            this.Linebtn.Text = "Line";
            this.Linebtn.UseVisualStyleBackColor = true;
            this.Linebtn.Click += new System.EventHandler(this.Linebtn_Click);
            // 
            // Rectanglebtn
            // 
            this.Rectanglebtn.Location = new System.Drawing.Point(21, 167);
            this.Rectanglebtn.Name = "Rectanglebtn";
            this.Rectanglebtn.Size = new System.Drawing.Size(82, 29);
            this.Rectanglebtn.TabIndex = 5;
            this.Rectanglebtn.Text = "Rectangle";
            this.Rectanglebtn.UseVisualStyleBackColor = true;
            this.Rectanglebtn.Click += new System.EventHandler(this.Rectanglebtn_Click);
            // 
            // Trianglebtn
            // 
            this.Trianglebtn.Location = new System.Drawing.Point(21, 215);
            this.Trianglebtn.Name = "Trianglebtn";
            this.Trianglebtn.Size = new System.Drawing.Size(82, 29);
            this.Trianglebtn.TabIndex = 6;
            this.Trianglebtn.Text = "Triangle";
            this.Trianglebtn.UseVisualStyleBackColor = true;
            this.Trianglebtn.Click += new System.EventHandler(this.Trianglebtn_Click);
            // 
            // Circlebtn
            // 
            this.Circlebtn.Location = new System.Drawing.Point(21, 262);
            this.Circlebtn.Name = "Circlebtn";
            this.Circlebtn.Size = new System.Drawing.Size(82, 29);
            this.Circlebtn.TabIndex = 7;
            this.Circlebtn.Text = "Circle";
            this.Circlebtn.UseVisualStyleBackColor = true;
            this.Circlebtn.Click += new System.EventHandler(this.Circlebtn_Click);
            // 
            // Starbtn
            // 
            this.Starbtn.Location = new System.Drawing.Point(21, 314);
            this.Starbtn.Name = "Starbtn";
            this.Starbtn.Size = new System.Drawing.Size(82, 29);
            this.Starbtn.TabIndex = 8;
            this.Starbtn.Text = "Star";
            this.Starbtn.UseVisualStyleBackColor = true;
            this.Starbtn.Click += new System.EventHandler(this.Starbtn_Click);
            // 
            // Fillbtn
            // 
            this.Fillbtn.Location = new System.Drawing.Point(21, 361);
            this.Fillbtn.Name = "Fillbtn";
            this.Fillbtn.Size = new System.Drawing.Size(82, 29);
            this.Fillbtn.TabIndex = 9;
            this.Fillbtn.Text = "Fill";
            this.Fillbtn.UseVisualStyleBackColor = true;
            this.Fillbtn.Click += new System.EventHandler(this.Fillbtn_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip3.TabIndex = 10;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(228, 27);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(120, 56);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1268, 592);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Fillbtn);
            this.Controls.Add(this.Starbtn);
            this.Controls.Add(this.Circlebtn);
            this.Controls.Add(this.Trianglebtn);
            this.Controls.Add(this.Rectanglebtn);
            this.Controls.Add(this.Linebtn);
            this.Controls.Add(this.Penbtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Line.ResumeLayout(false);
            this.Line.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button Line_btn;
        private System.Windows.Forms.Button Rectangle_btn;
        private System.Windows.Forms.Button Ellipse_btn;
        private System.Windows.Forms.Button Star_btn;
        private System.Windows.Forms.Button Triangle_btn;
        private System.Windows.Forms.Button Fill_btn;
        private System.Windows.Forms.Button Pen_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip Line;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button Penbtn;
        private System.Windows.Forms.Button Linebtn;
        private System.Windows.Forms.Button Rectanglebtn;
        private System.Windows.Forms.Button Trianglebtn;
        private System.Windows.Forms.Button Circlebtn;
        private System.Windows.Forms.Button Starbtn;
        private System.Windows.Forms.Button Fillbtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.ColorDialog colorDialog5;
        private System.Windows.Forms.ToolStripMenuItem rubberToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

