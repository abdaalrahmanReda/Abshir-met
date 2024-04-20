namespace Abshir
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.Monthlybutt = new System.Windows.Forms.Button();
            this.CasesButt = new System.Windows.Forms.Button();
            this.DonorsButt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(156)))));
            this.sidepanel.Controls.Add(this.button2);
            this.sidepanel.Controls.Add(this.Monthlybutt);
            this.sidepanel.Controls.Add(this.CasesButt);
            this.sidepanel.Controls.Add(this.DonorsButt);
            this.sidepanel.Controls.Add(this.pictureBox1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(306, 886);
            this.sidepanel.TabIndex = 0;
            // 
            // Monthlybutt
            // 
            this.Monthlybutt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monthlybutt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(156)))));
            this.Monthlybutt.Location = new System.Drawing.Point(12, 483);
            this.Monthlybutt.Name = "Monthlybutt";
            this.Monthlybutt.Size = new System.Drawing.Size(268, 53);
            this.Monthlybutt.TabIndex = 6;
            this.Monthlybutt.Text = "MonthlyAssistamces";
            this.Monthlybutt.UseVisualStyleBackColor = true;
            // 
            // CasesButt
            // 
            this.CasesButt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CasesButt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(156)))));
            this.CasesButt.Location = new System.Drawing.Point(12, 376);
            this.CasesButt.Name = "CasesButt";
            this.CasesButt.Size = new System.Drawing.Size(268, 53);
            this.CasesButt.TabIndex = 5;
            this.CasesButt.Text = "Cases";
            this.CasesButt.UseVisualStyleBackColor = true;
            // 
            // DonorsButt
            // 
            this.DonorsButt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorsButt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(156)))));
            this.DonorsButt.Location = new System.Drawing.Point(12, 271);
            this.DonorsButt.Name = "DonorsButt";
            this.DonorsButt.Size = new System.Drawing.Size(268, 53);
            this.DonorsButt.TabIndex = 4;
            this.DonorsButt.Text = "Donors";
            this.DonorsButt.UseVisualStyleBackColor = true;
            this.DonorsButt.Click += new System.EventHandler(this.DonorsButt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.panel1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(306, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1038, 886);
            this.mainpanel.TabIndex = 0;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(156)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 58);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 886);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.sidepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Monthlybutt;
        private System.Windows.Forms.Button CasesButt;
        private System.Windows.Forms.Button DonorsButt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}