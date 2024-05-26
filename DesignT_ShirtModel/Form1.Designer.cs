namespace DesignT_ShirtModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelNote = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.hX = new System.Windows.Forms.HScrollBar();
            this.hO = new System.Windows.Forms.HScrollBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ptAnh = new System.Windows.Forms.PictureBox();
            this.tùyChỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhMockupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChỉnhToolStripMenuItem,
            this.chỉnhMockupToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(731, 357);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(48, 22);
            this.labelNote.TabIndex = 130;
            this.labelNote.Text = "Note";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(745, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 35);
            this.button5.TabIndex = 155;
            this.button5.Text = "Tổng hợp";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(745, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 35);
            this.button2.TabIndex = 154;
            this.button2.Text = "Lưu kết quả";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(669, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 35);
            this.button4.TabIndex = 153;
            this.button4.Text = "Prev";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(868, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 35);
            this.button3.TabIndex = 152;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 151;
            this.label1.Text = "0/0";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(741, 103);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(75, 22);
            this.lbX.TabIndex = 150;
            this.lbX.Text = "0 (Turn)";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO.Location = new System.Drawing.Point(741, 54);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(121, 22);
            this.labelO.TabIndex = 149;
            this.labelO.Text = "100 (Opacity)";
            // 
            // hX
            // 
            this.hX.Location = new System.Drawing.Point(12, 91);
            this.hX.Maximum = 110;
            this.hX.Minimum = -120;
            this.hX.Name = "hX";
            this.hX.Size = new System.Drawing.Size(640, 34);
            this.hX.TabIndex = 148;
            this.hX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hX_Scroll);
            // 
            // hO
            // 
            this.hO.Location = new System.Drawing.Point(12, 43);
            this.hO.Maximum = 120;
            this.hO.Minimum = -20;
            this.hO.Name = "hO";
            this.hO.Size = new System.Drawing.Size(640, 33);
            this.hO.TabIndex = 147;
            this.hO.Value = 120;
            this.hO.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hO_Scroll);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(745, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 35);
            this.button7.TabIndex = 146;
            this.button7.Text = "Reload";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(745, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 35);
            this.button6.TabIndex = 145;
            this.button6.Text = "Lưu thay đổi";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ptAnh
            // 
            this.ptAnh.BackColor = System.Drawing.Color.Silver;
            this.ptAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptAnh.Location = new System.Drawing.Point(12, 141);
            this.ptAnh.Name = "ptAnh";
            this.ptAnh.Size = new System.Drawing.Size(640, 640);
            this.ptAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAnh.TabIndex = 144;
            this.ptAnh.TabStop = false;
            this.ptAnh.Click += new System.EventHandler(this.ptAnh_Click);
            // 
            // tùyChỉnhToolStripMenuItem
            // 
            this.tùyChỉnhToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tùyChỉnhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tùyChỉnhToolStripMenuItem.Image")));
            this.tùyChỉnhToolStripMenuItem.Name = "tùyChỉnhToolStripMenuItem";
            this.tùyChỉnhToolStripMenuItem.Size = new System.Drawing.Size(127, 27);
            this.tùyChỉnhToolStripMenuItem.Text = "Tùy chỉnh";
            this.tùyChỉnhToolStripMenuItem.Click += new System.EventHandler(this.tùyChỉnhToolStripMenuItem_Click);
            // 
            // chỉnhMockupToolStripMenuItem
            // 
            this.chỉnhMockupToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chỉnhMockupToolStripMenuItem.Image = global::DesignT_ShirtModel.Properties.Resources.setting;
            this.chỉnhMockupToolStripMenuItem.Name = "chỉnhMockupToolStripMenuItem";
            this.chỉnhMockupToolStripMenuItem.Size = new System.Drawing.Size(166, 27);
            this.chỉnhMockupToolStripMenuItem.Text = "Chỉnh Mockup";
            this.chỉnhMockupToolStripMenuItem.Click += new System.EventHandler(this.chỉnhMockupToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(995, 790);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.hX);
            this.Controls.Add(this.hO);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ptAnh);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Design a t-shirt model";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tùyChỉnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.HScrollBar hX;
        private System.Windows.Forms.HScrollBar hO;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox ptAnh;
        private System.Windows.Forms.ToolStripMenuItem chỉnhMockupToolStripMenuItem;
    }
}

