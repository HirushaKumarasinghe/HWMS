namespace HWMS.UI
{
    partial class Trahs2
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
            this.ownerProfile = new System.Windows.Forms.Panel();
            this.xownerPanel = new System.Windows.Forms.Panel();
            this.assertsF = new System.Windows.Forms.Button();
            this.accountsF = new System.Windows.Forms.Button();
            this.stockF = new System.Windows.Forms.Button();
            this.employeeF = new System.Windows.Forms.Button();
            this.ownerProfile.SuspendLayout();
            this.xownerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ownerProfile
            // 
            this.ownerProfile.Controls.Add(this.xownerPanel);
            this.ownerProfile.Location = new System.Drawing.Point(35, 35);
            this.ownerProfile.Name = "ownerProfile";
            this.ownerProfile.Size = new System.Drawing.Size(784, 518);
            this.ownerProfile.TabIndex = 16;
            this.ownerProfile.Visible = false;
            // 
            // xownerPanel
            // 
            this.xownerPanel.BackColor = System.Drawing.Color.Plum;
            this.xownerPanel.Controls.Add(this.assertsF);
            this.xownerPanel.Controls.Add(this.accountsF);
            this.xownerPanel.Controls.Add(this.stockF);
            this.xownerPanel.Controls.Add(this.employeeF);
            this.xownerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.xownerPanel.Location = new System.Drawing.Point(0, 0);
            this.xownerPanel.Name = "xownerPanel";
            this.xownerPanel.Size = new System.Drawing.Size(174, 518);
            this.xownerPanel.TabIndex = 0;
            // 
            // assertsF
            // 
            this.assertsF.Location = new System.Drawing.Point(41, 248);
            this.assertsF.Name = "assertsF";
            this.assertsF.Size = new System.Drawing.Size(113, 23);
            this.assertsF.TabIndex = 5;
            this.assertsF.Text = "Asserts";
            this.assertsF.UseVisualStyleBackColor = true;
            // 
            // accountsF
            // 
            this.accountsF.Location = new System.Drawing.Point(41, 202);
            this.accountsF.Name = "accountsF";
            this.accountsF.Size = new System.Drawing.Size(113, 23);
            this.accountsF.TabIndex = 4;
            this.accountsF.Text = "Accounts";
            this.accountsF.UseVisualStyleBackColor = true;
            // 
            // stockF
            // 
            this.stockF.Location = new System.Drawing.Point(41, 334);
            this.stockF.Name = "stockF";
            this.stockF.Size = new System.Drawing.Size(113, 23);
            this.stockF.TabIndex = 1;
            this.stockF.Text = "Stock";
            this.stockF.UseVisualStyleBackColor = true;
            // 
            // employeeF
            // 
            this.employeeF.Location = new System.Drawing.Point(41, 295);
            this.employeeF.Name = "employeeF";
            this.employeeF.Size = new System.Drawing.Size(113, 23);
            this.employeeF.TabIndex = 0;
            this.employeeF.Text = "Employee Details";
            this.employeeF.UseVisualStyleBackColor = true;
            // 
            // Trahs2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 589);
            this.Controls.Add(this.ownerProfile);
            this.Name = "Trahs2";
            this.Text = "Trahs2";
            this.ownerProfile.ResumeLayout(false);
            this.xownerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ownerProfile;
        private System.Windows.Forms.Panel xownerPanel;
        private System.Windows.Forms.Button assertsF;
        private System.Windows.Forms.Button accountsF;
        private System.Windows.Forms.Button stockF;
        private System.Windows.Forms.Button employeeF;
    }
}