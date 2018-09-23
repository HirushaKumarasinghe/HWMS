namespace HWMS
{
    partial class stcokTrash
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
            this.stockProfile = new System.Windows.Forms.Panel();
            this.xownerPanel = new System.Windows.Forms.Panel();
            this.supplierF = new System.Windows.Forms.Button();
            this.viewStockF = new System.Windows.Forms.Button();
            this.stockF = new System.Windows.Forms.Button();
            this.restockF = new System.Windows.Forms.Button();
            this.stockProfile.SuspendLayout();
            this.xownerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockProfile
            // 
            this.stockProfile.Controls.Add(this.xownerPanel);
            this.stockProfile.Location = new System.Drawing.Point(33, 36);
            this.stockProfile.Name = "stockProfile";
            this.stockProfile.Size = new System.Drawing.Size(784, 518);
            this.stockProfile.TabIndex = 17;
            this.stockProfile.Visible = false;
            // 
            // xownerPanel
            // 
            this.xownerPanel.BackColor = System.Drawing.Color.Plum;
            this.xownerPanel.Controls.Add(this.supplierF);
            this.xownerPanel.Controls.Add(this.viewStockF);
            this.xownerPanel.Controls.Add(this.stockF);
            this.xownerPanel.Controls.Add(this.restockF);
            this.xownerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.xownerPanel.Location = new System.Drawing.Point(0, 0);
            this.xownerPanel.Name = "xownerPanel";
            this.xownerPanel.Size = new System.Drawing.Size(174, 518);
            this.xownerPanel.TabIndex = 0;
            // 
            // supplierF
            // 
            this.supplierF.Location = new System.Drawing.Point(41, 248);
            this.supplierF.Name = "supplierF";
            this.supplierF.Size = new System.Drawing.Size(113, 23);
            this.supplierF.TabIndex = 5;
            this.supplierF.Text = "Supplier";
            this.supplierF.UseVisualStyleBackColor = true;
            // 
            // viewStockF
            // 
            this.viewStockF.Location = new System.Drawing.Point(41, 202);
            this.viewStockF.Name = "viewStockF";
            this.viewStockF.Size = new System.Drawing.Size(113, 23);
            this.viewStockF.TabIndex = 4;
            this.viewStockF.Text = "View Stock";
            this.viewStockF.UseVisualStyleBackColor = true;
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
            // restockF
            // 
            this.restockF.Location = new System.Drawing.Point(41, 295);
            this.restockF.Name = "restockF";
            this.restockF.Size = new System.Drawing.Size(113, 23);
            this.restockF.TabIndex = 0;
            this.restockF.Text = "Employee Details";
            this.restockF.UseVisualStyleBackColor = true;
            // 
            // stcokTrash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 590);
            this.Controls.Add(this.stockProfile);
            this.Name = "stcokTrash";
            this.Text = "stcokTrash";
            this.stockProfile.ResumeLayout(false);
            this.xownerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stockProfile;
        private System.Windows.Forms.Panel xownerPanel;
        private System.Windows.Forms.Button supplierF;
        private System.Windows.Forms.Button viewStockF;
        private System.Windows.Forms.Button stockF;
        private System.Windows.Forms.Button restockF;
    }
}