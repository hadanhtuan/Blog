namespace Blog
{
    partial class FormCreatePost
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.txbContent = new System.Windows.Forms.TextBox();
            this.cboTag = new System.Windows.Forms.ComboBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chb1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Content";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Post some thing ...";
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(242, 82);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(455, 22);
            this.txbTitle.TabIndex = 10;
            // 
            // txbContent
            // 
            this.txbContent.AllowDrop = true;
            this.txbContent.Location = new System.Drawing.Point(242, 142);
            this.txbContent.Multiline = true;
            this.txbContent.Name = "txbContent";
            this.txbContent.Size = new System.Drawing.Size(455, 172);
            this.txbContent.TabIndex = 11;
            // 
            // cboTag
            // 
            this.cboTag.FormattingEnabled = true;
            this.cboTag.Location = new System.Drawing.Point(243, 356);
            this.cboTag.Name = "cboTag";
            this.cboTag.Size = new System.Drawing.Size(177, 24);
            this.cboTag.TabIndex = 12;
            // 
            // ptb1
            // 
            this.ptb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb1.Location = new System.Drawing.Point(243, 412);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(177, 89);
            this.ptb1.TabIndex = 13;
            this.ptb1.TabStop = false;
            // 
            // ptb2
            // 
            this.ptb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb2.Location = new System.Drawing.Point(167, 48);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(178, 89);
            this.ptb2.TabIndex = 14;
            this.ptb2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Choose image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Choose image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(672, 676);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 42);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptb2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(75, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 186);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Location = new System.Drawing.Point(547, 516);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(84, 20);
            this.chb1.TabIndex = 20;
            this.chb1.Text = "2 image?";
            this.chb1.UseVisualStyleBackColor = true;
            this.chb1.CheckedChanged += new System.EventHandler(this.chb1_CheckedChanged);
            // 
            // FormCreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(814, 730);
            this.Controls.Add(this.chb1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.cboTag);
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.txbTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreatePost";
            this.Text = "FormCreatePost";
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.TextBox txbContent;
        private System.Windows.Forms.ComboBox cboTag;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chb1;
    }
}