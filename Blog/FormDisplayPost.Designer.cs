namespace Blog
{
    partial class FormDisplayPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayPost));
            this.pnlPost = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ptbAvt = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlCmt = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.lblUN4 = new System.Windows.Forms.Label();
            this.lblContent4 = new System.Windows.Forms.Label();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.lblUN3 = new System.Windows.Forms.Label();
            this.lblContent3 = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblUN2 = new System.Windows.Forms.Label();
            this.lblContent2 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblUN1 = new System.Windows.Forms.Label();
            this.lblContent1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCmt = new System.Windows.Forms.TextBox();
            this.ptbSend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlCmt.SuspendLayout();
            this.pnl4.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSend)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPost
            // 
            this.pnlPost.Location = new System.Drawing.Point(24, 159);
            this.pnlPost.Name = "pnlPost";
            this.pnlPost.Size = new System.Drawing.Size(710, 616);
            this.pnlPost.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(16, 71);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 47);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(310, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 38);
            this.textBox1.TabIndex = 4;
            // 
            // ptbAvt
            // 
            this.ptbAvt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAvt.Location = new System.Drawing.Point(805, -14);
            this.ptbAvt.Name = "ptbAvt";
            this.ptbAvt.Size = new System.Drawing.Size(58, 41);
            this.ptbAvt.TabIndex = 5;
            this.ptbAvt.TabStop = false;
            this.ptbAvt.Click += new System.EventHandler(this.ptbAvt_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(16, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "manage account";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(746, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 129);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(253, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(64, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 42);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(310, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 39);
            this.button4.TabIndex = 10;
            this.button4.Text = "Post some thing!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlCmt
            // 
            this.pnlCmt.Controls.Add(this.pnl4);
            this.pnlCmt.Controls.Add(this.pnl3);
            this.pnlCmt.Controls.Add(this.pnl2);
            this.pnlCmt.Controls.Add(this.pnl1);
            this.pnlCmt.Location = new System.Drawing.Point(753, 342);
            this.pnlCmt.Name = "pnlCmt";
            this.pnlCmt.Size = new System.Drawing.Size(238, 433);
            this.pnlCmt.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(743, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Write comment";
            // 
            // pnl4
            // 
            this.pnl4.Controls.Add(this.lblUN4);
            this.pnl4.Controls.Add(this.lblContent4);
            this.pnl4.Location = new System.Drawing.Point(0, 321);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(235, 100);
            this.pnl4.TabIndex = 3;
            // 
            // lblUN4
            // 
            this.lblUN4.AutoSize = true;
            this.lblUN4.Location = new System.Drawing.Point(18, 11);
            this.lblUN4.Name = "lblUN4";
            this.lblUN4.Size = new System.Drawing.Size(0, 16);
            this.lblUN4.TabIndex = 2;
            // 
            // lblContent4
            // 
            this.lblContent4.AllowDrop = true;
            this.lblContent4.Location = new System.Drawing.Point(18, 40);
            this.lblContent4.Name = "lblContent4";
            this.lblContent4.Size = new System.Drawing.Size(156, 48);
            this.lblContent4.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.Controls.Add(this.lblUN3);
            this.pnl3.Controls.Add(this.lblContent3);
            this.pnl3.Location = new System.Drawing.Point(3, 215);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(232, 100);
            this.pnl3.TabIndex = 3;
            // 
            // lblUN3
            // 
            this.lblUN3.AutoSize = true;
            this.lblUN3.Location = new System.Drawing.Point(18, 11);
            this.lblUN3.Name = "lblUN3";
            this.lblUN3.Size = new System.Drawing.Size(0, 16);
            this.lblUN3.TabIndex = 2;
            // 
            // lblContent3
            // 
            this.lblContent3.AllowDrop = true;
            this.lblContent3.Location = new System.Drawing.Point(18, 40);
            this.lblContent3.Name = "lblContent3";
            this.lblContent3.Size = new System.Drawing.Size(156, 48);
            this.lblContent3.TabIndex = 1;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.lblUN2);
            this.pnl2.Controls.Add(this.lblContent2);
            this.pnl2.Location = new System.Drawing.Point(3, 109);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(232, 100);
            this.pnl2.TabIndex = 3;
            // 
            // lblUN2
            // 
            this.lblUN2.AutoSize = true;
            this.lblUN2.Location = new System.Drawing.Point(18, 11);
            this.lblUN2.Name = "lblUN2";
            this.lblUN2.Size = new System.Drawing.Size(0, 16);
            this.lblUN2.TabIndex = 2;
            // 
            // lblContent2
            // 
            this.lblContent2.AllowDrop = true;
            this.lblContent2.Location = new System.Drawing.Point(18, 40);
            this.lblContent2.Name = "lblContent2";
            this.lblContent2.Size = new System.Drawing.Size(156, 48);
            this.lblContent2.TabIndex = 1;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.lblUN1);
            this.pnl1.Controls.Add(this.lblContent1);
            this.pnl1.Location = new System.Drawing.Point(3, 3);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(232, 100);
            this.pnl1.TabIndex = 0;
            // 
            // lblUN1
            // 
            this.lblUN1.AutoSize = true;
            this.lblUN1.Location = new System.Drawing.Point(18, 11);
            this.lblUN1.Name = "lblUN1";
            this.lblUN1.Size = new System.Drawing.Size(0, 16);
            this.lblUN1.TabIndex = 2;
            // 
            // lblContent1
            // 
            this.lblContent1.AllowDrop = true;
            this.lblContent1.Location = new System.Drawing.Point(18, 40);
            this.lblContent1.Name = "lblContent1";
            this.lblContent1.Size = new System.Drawing.Size(156, 48);
            this.lblContent1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 787);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Read more ...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbCmt
            // 
            this.txbCmt.Location = new System.Drawing.Point(752, 315);
            this.txbCmt.Name = "txbCmt";
            this.txbCmt.Size = new System.Drawing.Size(188, 22);
            this.txbCmt.TabIndex = 12;
            // 
            // ptbSend
            // 
            this.ptbSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbSend.BackgroundImage")));
            this.ptbSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbSend.Location = new System.Drawing.Point(946, 303);
            this.ptbSend.Name = "ptbSend";
            this.ptbSend.Size = new System.Drawing.Size(45, 36);
            this.ptbSend.TabIndex = 13;
            this.ptbSend.TabStop = false;
            this.ptbSend.Click += new System.EventHandler(this.ptbSend_Click);
            // 
            // FormDisplayPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 840);
            this.Controls.Add(this.ptbSend);
            this.Controls.Add(this.txbCmt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCmt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbAvt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlPost);
            this.Name = "FormDisplayPost";
            this.Text = "   ";
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlCmt.ResumeLayout(false);
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox ptbAvt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlCmt;
        private System.Windows.Forms.Label lblUN1;
        private System.Windows.Forms.Label lblContent1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Label lblUN4;
        private System.Windows.Forms.Label lblContent4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Label lblUN3;
        private System.Windows.Forms.Label lblContent3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblUN2;
        private System.Windows.Forms.Label lblContent2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCmt;
        private System.Windows.Forms.PictureBox ptbSend;
    }
}