namespace HWMS
{
    partial class cashierTrash
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
            this.cashierProfile = new System.Windows.Forms.Panel();
            this.xownerPanel = new System.Windows.Forms.Panel();
            this.posF = new System.Windows.Forms.Button();
            this.addCourierF = new System.Windows.Forms.Button();
            this.stockF = new System.Windows.Forms.Button();
            this.addOrderF = new System.Windows.Forms.Button();
            this.cashierProfile.SuspendLayout();
            this.xownerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashierProfile
            // 
            this.cashierProfile.Controls.Add(this.xownerPanel);
            this.cashierProfile.Location = new System.Drawing.Point(28, 32);
            this.cashierProfile.Name = "cashierProfile";
            this.cashierProfile.Size = new System.Drawing.Size(784, 518);
            this.cashierProfile.TabIndex = 17;
            this.cashierProfile.Visible = false;
            // 
            // xownerPanel
            // 
            this.xownerPanel.BackColor = System.Drawing.Color.Plum;
            this.xownerPanel.Controls.Add(this.posF);
            this.xownerPanel.Controls.Add(this.addCourierF);
            this.xownerPanel.Controls.Add(this.stockF);
            this.xownerPanel.Controls.Add(this.addOrderF);
            this.xownerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.xownerPanel.Location = new System.Drawing.Point(0, 0);
            this.xownerPanel.Name = "xownerPanel";
            this.xownerPanel.Size = new System.Drawing.Size(174, 518);
            this.xownerPanel.TabIndex = 0;
            // 
            // posF
            // 
            this.posF.Location = new System.Drawing.Point(36, 248);
            this.posF.Name = "posF";
            this.posF.Size = new System.Drawing.Size(118, 23);
            this.posF.TabIndex = 5;
            this.posF.Text = "Point of Sale";
            this.posF.UseVisualStyleBackColor = true;
            // 
            // addCourierF
            // 
            this.addCourierF.Location = new System.Drawing.Point(36, 202);
            this.addCourierF.Name = "addCourierF";
            this.addCourierF.Size = new System.Drawing.Size(118, 23);
            this.addCourierF.TabIndex = 4;
            this.addCourierF.Text = "Add Courier";
            this.addCourierF.UseVisualStyleBackColor = true;
            // 
            // stockF
            // 
            this.stockF.Location = new System.Drawing.Point(36, 334);
            this.stockF.Name = "stockF";
            this.stockF.Size = new System.Drawing.Size(118, 23);
            this.stockF.TabIndex = 1;
            this.stockF.Text = "Permanent Customers";
            this.stockF.UseVisualStyleBackColor = true;
            // 
            // addOrderF
            // 
            this.addOrderF.Location = new System.Drawing.Point(36, 295);
            this.addOrderF.Name = "addOrderF";
            this.addOrderF.Size = new System.Drawing.Size(118, 23);
            this.addOrderF.TabIndex = 0;
            this.addOrderF.Text = "Customer Order";
            this.addOrderF.UseVisualStyleBackColor = true;
            // 
            // cashierTrash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 582);
            this.Controls.Add(this.cashierProfile);
            this.Name = "cashierTrash";
            this.Text = "cashierTrash";
            this.cashierProfile.ResumeLayout(false);
            this.xownerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cashierProfile;
        private System.Windows.Forms.Panel xownerPanel;
        private System.Windows.Forms.Button posF;
        private System.Windows.Forms.Button addCourierF;
        private System.Windows.Forms.Button stockF;
        private System.Windows.Forms.Button addOrderF;
    }
}