namespace HWMS.UI
{
    partial class Trash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trash));
            this.resetPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.resetPConfirmPassword = new System.Windows.Forms.TextBox();
            this.resetPNewPassword = new System.Windows.Forms.TextBox();
            this.resetPRestBtn = new System.Windows.Forms.Button();
            this.resetPPassword = new System.Windows.Forms.TextBox();
            this.resetUserName = new System.Windows.Forms.TextBox();
            this.resetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // resetPanel
            // 
            this.resetPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetPanel.Controls.Add(this.label3);
            this.resetPanel.Controls.Add(this.label2);
            this.resetPanel.Controls.Add(this.label1);
            this.resetPanel.Controls.Add(this.pictureBox2);
            this.resetPanel.Controls.Add(this.resetPConfirmPassword);
            this.resetPanel.Controls.Add(this.resetPNewPassword);
            this.resetPanel.Controls.Add(this.resetPRestBtn);
            this.resetPanel.Controls.Add(this.resetPPassword);
            this.resetPanel.Controls.Add(this.resetUserName);
            this.resetPanel.Location = new System.Drawing.Point(36, 36);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(784, 518);
            this.resetPanel.TabIndex = 3;
            this.resetPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Confirm New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Current Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(344, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // resetPConfirmPassword
            // 
            this.resetPConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetPConfirmPassword.Location = new System.Drawing.Point(260, 363);
            this.resetPConfirmPassword.Name = "resetPConfirmPassword";
            this.resetPConfirmPassword.Size = new System.Drawing.Size(265, 20);
            this.resetPConfirmPassword.TabIndex = 21;
            this.resetPConfirmPassword.Text = "Password";
            this.resetPConfirmPassword.UseSystemPasswordChar = true;
            // 
            // resetPNewPassword
            // 
            this.resetPNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetPNewPassword.Location = new System.Drawing.Point(260, 310);
            this.resetPNewPassword.Name = "resetPNewPassword";
            this.resetPNewPassword.Size = new System.Drawing.Size(265, 20);
            this.resetPNewPassword.TabIndex = 20;
            this.resetPNewPassword.Text = "Password";
            this.resetPNewPassword.UseSystemPasswordChar = true;
            // 
            // resetPRestBtn
            // 
            this.resetPRestBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetPRestBtn.Location = new System.Drawing.Point(333, 407);
            this.resetPRestBtn.Name = "resetPRestBtn";
            this.resetPRestBtn.Size = new System.Drawing.Size(118, 23);
            this.resetPRestBtn.TabIndex = 19;
            this.resetPRestBtn.Text = "Reset Password";
            this.resetPRestBtn.UseVisualStyleBackColor = true;
            // 
            // resetPPassword
            // 
            this.resetPPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetPPassword.Location = new System.Drawing.Point(260, 257);
            this.resetPPassword.Name = "resetPPassword";
            this.resetPPassword.Size = new System.Drawing.Size(265, 20);
            this.resetPPassword.TabIndex = 16;
            this.resetPPassword.Text = "Password";
            this.resetPPassword.UseSystemPasswordChar = true;
            // 
            // resetUserName
            // 
            this.resetUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetUserName.Location = new System.Drawing.Point(260, 194);
            this.resetUserName.Name = "resetUserName";
            this.resetUserName.Size = new System.Drawing.Size(265, 20);
            this.resetUserName.TabIndex = 15;
            this.resetUserName.Text = "User Name";
            // 
            // Trash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 590);
            this.Controls.Add(this.resetPanel);
            this.Name = "Trash";
            this.Text = "Trash";
            this.resetPanel.ResumeLayout(false);
            this.resetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel resetPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox resetPConfirmPassword;
        private System.Windows.Forms.TextBox resetPNewPassword;
        private System.Windows.Forms.Button resetPRestBtn;
        private System.Windows.Forms.TextBox resetPPassword;
        private System.Windows.Forms.TextBox resetUserName;
    }
}