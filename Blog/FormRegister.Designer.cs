namespace Blog
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.txbUN = new System.Windows.Forms.TextBox();
            this.txbPW = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbCPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUN
            // 
            this.txbUN.Location = new System.Drawing.Point(220, 43);
            this.txbUN.Name = "txbUN";
            this.txbUN.Size = new System.Drawing.Size(300, 22);
            this.txbUN.TabIndex = 0;
            // 
            // txbPW
            // 
            this.txbPW.Location = new System.Drawing.Point(220, 182);
            this.txbPW.Name = "txbPW";
            this.txbPW.Size = new System.Drawing.Size(300, 22);
            this.txbPW.TabIndex = 2;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(220, 114);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(300, 22);
            this.txbEmail.TabIndex = 3;
            // 
            // txbCPW
            // 
            this.txbCPW.Location = new System.Drawing.Point(220, 258);
            this.txbCPW.Name = "txbCPW";
            this.txbCPW.Size = new System.Drawing.Size(290, 22);
            this.txbCPW.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // ptb1
            // 
            this.ptb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb1.BackgroundImage")));
            this.ptb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb1.Location = new System.Drawing.Point(220, 399);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(206, 143);
            this.ptb1.TabIndex = 6;
            this.ptb1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(81, 438);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(95, 54);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Choose image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cboAge
            // 
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(220, 333);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(92, 24);
            this.cboAge.TabIndex = 14;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(611, 592);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 41);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(478, 592);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 41);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 662);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cboAge);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.txbCPW);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPW);
            this.Controls.Add(this.txbUN);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUN;
        private System.Windows.Forms.TextBox txbPW;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbCPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSubmit;
    }
}