namespace Blog
{
    partial class FormPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPost));
            this.lblUN = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumCmt = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.ptbImage1 = new System.Windows.Forms.PictureBox();
            this.ptbImage21 = new System.Windows.Forms.PictureBox();
            this.ptbImage22 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage22)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Location = new System.Drawing.Point(188, 80);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(67, 16);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "username";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTag.Location = new System.Drawing.Point(46, 114);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(33, 16);
            this.lblTag.TabIndex = 1;
            this.lblTag.Text = "#tag";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(44, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(658, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "title Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(46, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "date";
            // 
            // lblNumCmt
            // 
            this.lblNumCmt.AutoSize = true;
            this.lblNumCmt.Location = new System.Drawing.Point(354, 80);
            this.lblNumCmt.Name = "lblNumCmt";
            this.lblNumCmt.Size = new System.Drawing.Size(110, 16);
            this.lblNumCmt.TabIndex = 5;
            this.lblNumCmt.Text = "number comment";
            // 
            // lblContent
            // 
            this.lblContent.AllowDrop = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(36, 142);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(658, 177);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = resources.GetString("lblContent.Text");
            // 
            // ptbImage1
            // 
            this.ptbImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage1.Location = new System.Drawing.Point(41, 322);
            this.ptbImage1.Name = "ptbImage1";
            this.ptbImage1.Size = new System.Drawing.Size(645, 279);
            this.ptbImage1.TabIndex = 7;
            this.ptbImage1.TabStop = false;
            // 
            // ptbImage21
            // 
            this.ptbImage21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage21.Location = new System.Drawing.Point(49, 322);
            this.ptbImage21.Name = "ptbImage21";
            this.ptbImage21.Size = new System.Drawing.Size(309, 269);
            this.ptbImage21.TabIndex = 8;
            this.ptbImage21.TabStop = false;
            this.ptbImage21.Visible = false;
            // 
            // ptbImage22
            // 
            this.ptbImage22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage22.Location = new System.Drawing.Point(401, 322);
            this.ptbImage22.Name = "ptbImage22";
            this.ptbImage22.Size = new System.Drawing.Size(293, 269);
            this.ptbImage22.TabIndex = 9;
            this.ptbImage22.TabStop = false;
            this.ptbImage22.Visible = false;
            // 
            // FormPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 644);
            this.Controls.Add(this.ptbImage22);
            this.Controls.Add(this.ptbImage21);
            this.Controls.Add(this.ptbImage1);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblNumCmt);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblUN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPost";
            this.Text = "Post";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumCmt;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.PictureBox ptbImage1;
        private System.Windows.Forms.PictureBox ptbImage21;
        private System.Windows.Forms.PictureBox ptbImage22;
    }
}