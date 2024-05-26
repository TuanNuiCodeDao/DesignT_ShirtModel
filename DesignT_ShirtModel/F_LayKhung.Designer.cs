namespace DesignT_ShirtModel
{
    partial class F_LayKhung
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ptAnh = new System.Windows.Forms.PictureBox();
            this.labelNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(643, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 146;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(183, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 147;
            this.button2.Text = "Reload";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ptAnh
            // 
            this.ptAnh.BackColor = System.Drawing.Color.Silver;
            this.ptAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptAnh.Location = new System.Drawing.Point(28, 58);
            this.ptAnh.Name = "ptAnh";
            this.ptAnh.Size = new System.Drawing.Size(640, 640);
            this.ptAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptAnh.TabIndex = 145;
            this.ptAnh.TabStop = false;
            this.ptAnh.Paint += new System.Windows.Forms.PaintEventHandler(this.ptAnh_Paint);
            this.ptAnh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptAnh_MouseDown);
            this.ptAnh.MouseLeave += new System.EventHandler(this.ptAnh_MouseLeave);
            this.ptAnh.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptAnh_MouseMove);
            this.ptAnh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptAnh_MouseUp);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(429, 21);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(48, 22);
            this.labelNote.TabIndex = 148;
            this.labelNote.Text = "Note";
            // 
            // F_LayKhung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 798);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptAnh);
            this.Name = "F_LayKhung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lấy khung ảnh 1";
            this.Load += new System.EventHandler(this.F_LayKhung_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.F_LayKhung_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_LayKhung_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.F_LayKhung_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.F_LayKhung_MouseUp);
            this.Move += new System.EventHandler(this.F_LayKhung_Move);
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptAnh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelNote;
    }
}