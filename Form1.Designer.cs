namespace PROJECT_Asciify {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numUpDownY = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(6, 549);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(78, 29);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveBitmapToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 22);
            this.toolStripMenuItem1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fileToolStripMenuItem.Text = "Load Image";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // saveBitmapToolStripMenuItem
            // 
            this.saveBitmapToolStripMenuItem.Name = "saveBitmapToolStripMenuItem";
            this.saveBitmapToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveBitmapToolStripMenuItem.Text = "Save Bitmap";
            this.saveBitmapToolStripMenuItem.Click += new System.EventHandler(this.SaveBitmapToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 7.875F);
            this.textBox1.Location = new System.Drawing.Point(256, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(820, 720);
            this.textBox1.TabIndex = 3;
            // 
            // numUpDownX
            // 
            this.numUpDownX.Location = new System.Drawing.Point(4, 2);
            this.numUpDownX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUpDownX.Name = "numUpDownX";
            this.numUpDownX.Size = new System.Drawing.Size(60, 20);
            this.numUpDownX.TabIndex = 10;
            this.numUpDownX.ValueChanged += new System.EventHandler(this.NumUpDownX_ValueChanged);
            // 
            // numUpDownY
            // 
            this.numUpDownY.Location = new System.Drawing.Point(4, 32);
            this.numUpDownY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUpDownY.Name = "numUpDownY";
            this.numUpDownY.Size = new System.Drawing.Size(60, 20);
            this.numUpDownY.TabIndex = 11;
            this.numUpDownY.ValueChanged += new System.EventHandler(this.NumUpDownY_ValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(120, 525);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.numUpDownX);
            this.splitContainer1.Panel2.Controls.Add(this.numUpDownY);
            this.splitContainer1.Size = new System.Drawing.Size(122, 53);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kernel X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kernel Y";
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(6, 54);
            this.picBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(225, 225);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 510);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownY)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBitmapToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numUpDownX;
        private System.Windows.Forms.NumericUpDown numUpDownY;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox;
    }
}

