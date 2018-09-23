namespace HWMS.UI
{
    partial class cashierTrashmain
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
            this.cashierMainP = new System.Windows.Forms.Panel();
            this.posP = new System.Windows.Forms.Panel();
            this.posPdiscardBill = new System.Windows.Forms.Button();
            this.posPpay = new System.Windows.Forms.Button();
            this.posPadd = new System.Windows.Forms.Button();
            this.posPlabel5 = new System.Windows.Forms.Label();
            this.posPlabel4 = new System.Windows.Forms.Label();
            this.posPlabel3 = new System.Windows.Forms.Label();
            this.posPlabel2 = new System.Windows.Forms.Label();
            this.posPlabel1 = new System.Windows.Forms.Label();
            this.manufacturercbox = new System.Windows.Forms.ComboBox();
            this.quntityNMD = new System.Windows.Forms.NumericUpDown();
            this.discountCheck = new System.Windows.Forms.CheckBox();
            this.itemIDcbox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNameT = new System.Windows.Forms.TextBox();
            this.cashierProperties = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.posB = new System.Windows.Forms.Button();
            this.cashierMainP.SuspendLayout();
            this.posP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quntityNMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cashierProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashierMainP
            // 
            this.cashierMainP.Controls.Add(this.posP);
            this.cashierMainP.Controls.Add(this.cashierProperties);
            this.cashierMainP.Location = new System.Drawing.Point(12, 12);
            this.cashierMainP.Name = "cashierMainP";
            this.cashierMainP.Size = new System.Drawing.Size(772, 454);
            this.cashierMainP.TabIndex = 0;
            // 
            // posP
            // 
            this.posP.Controls.Add(this.posPdiscardBill);
            this.posP.Controls.Add(this.posPpay);
            this.posP.Controls.Add(this.posPadd);
            this.posP.Controls.Add(this.posPlabel5);
            this.posP.Controls.Add(this.posPlabel4);
            this.posP.Controls.Add(this.posPlabel3);
            this.posP.Controls.Add(this.posPlabel2);
            this.posP.Controls.Add(this.posPlabel1);
            this.posP.Controls.Add(this.manufacturercbox);
            this.posP.Controls.Add(this.quntityNMD);
            this.posP.Controls.Add(this.discountCheck);
            this.posP.Controls.Add(this.itemIDcbox);
            this.posP.Controls.Add(this.dataGridView1);
            this.posP.Controls.Add(this.itemNameT);
            this.posP.Location = new System.Drawing.Point(0, 39);
            this.posP.Name = "posP";
            this.posP.Size = new System.Drawing.Size(772, 458);
            this.posP.TabIndex = 1;
            // 
            // posPdiscardBill
            // 
            this.posPdiscardBill.Location = new System.Drawing.Point(334, 339);
            this.posPdiscardBill.Name = "posPdiscardBill";
            this.posPdiscardBill.Size = new System.Drawing.Size(75, 23);
            this.posPdiscardBill.TabIndex = 49;
            this.posPdiscardBill.Text = "Discard Bill";
            this.posPdiscardBill.UseVisualStyleBackColor = true;
            // 
            // posPpay
            // 
            this.posPpay.Location = new System.Drawing.Point(476, 339);
            this.posPpay.Name = "posPpay";
            this.posPpay.Size = new System.Drawing.Size(75, 23);
            this.posPpay.TabIndex = 48;
            this.posPpay.Text = "Pay";
            this.posPpay.UseVisualStyleBackColor = true;
            // 
            // posPadd
            // 
            this.posPadd.Location = new System.Drawing.Point(187, 339);
            this.posPadd.Name = "posPadd";
            this.posPadd.Size = new System.Drawing.Size(75, 23);
            this.posPadd.TabIndex = 47;
            this.posPadd.Text = "Add";
            this.posPadd.UseVisualStyleBackColor = true;
            // 
            // posPlabel5
            // 
            this.posPlabel5.AutoSize = true;
            this.posPlabel5.Location = new System.Drawing.Point(43, 202);
            this.posPlabel5.Name = "posPlabel5";
            this.posPlabel5.Size = new System.Drawing.Size(46, 13);
            this.posPlabel5.TabIndex = 46;
            this.posPlabel5.Text = "Quantity";
            // 
            // posPlabel4
            // 
            this.posPlabel4.AutoSize = true;
            this.posPlabel4.Location = new System.Drawing.Point(43, 150);
            this.posPlabel4.Name = "posPlabel4";
            this.posPlabel4.Size = new System.Drawing.Size(70, 13);
            this.posPlabel4.TabIndex = 45;
            this.posPlabel4.Text = "Manufacturer";
            // 
            // posPlabel3
            // 
            this.posPlabel3.AutoSize = true;
            this.posPlabel3.Location = new System.Drawing.Point(43, 102);
            this.posPlabel3.Name = "posPlabel3";
            this.posPlabel3.Size = new System.Drawing.Size(58, 13);
            this.posPlabel3.TabIndex = 44;
            this.posPlabel3.Text = "Item Name";
            // 
            // posPlabel2
            // 
            this.posPlabel2.AutoSize = true;
            this.posPlabel2.Location = new System.Drawing.Point(43, 250);
            this.posPlabel2.Name = "posPlabel2";
            this.posPlabel2.Size = new System.Drawing.Size(78, 13);
            this.posPlabel2.TabIndex = 43;
            this.posPlabel2.Text = "Need Discount";
            this.posPlabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // posPlabel1
            // 
            this.posPlabel1.AutoSize = true;
            this.posPlabel1.Location = new System.Drawing.Point(43, 58);
            this.posPlabel1.Name = "posPlabel1";
            this.posPlabel1.Size = new System.Drawing.Size(41, 13);
            this.posPlabel1.TabIndex = 42;
            this.posPlabel1.Text = "Item ID";
            // 
            // manufacturercbox
            // 
            this.manufacturercbox.DisplayMember = "customerID";
            this.manufacturercbox.FormattingEnabled = true;
            this.manufacturercbox.Location = new System.Drawing.Point(196, 142);
            this.manufacturercbox.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturercbox.Name = "manufacturercbox";
            this.manufacturercbox.Size = new System.Drawing.Size(138, 21);
            this.manufacturercbox.TabIndex = 41;
            // 
            // quntityNMD
            // 
            this.quntityNMD.Location = new System.Drawing.Point(196, 195);
            this.quntityNMD.Margin = new System.Windows.Forms.Padding(2);
            this.quntityNMD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quntityNMD.Name = "quntityNMD";
            this.quntityNMD.Size = new System.Drawing.Size(136, 20);
            this.quntityNMD.TabIndex = 40;
            // 
            // discountCheck
            // 
            this.discountCheck.AutoSize = true;
            this.discountCheck.Location = new System.Drawing.Point(196, 246);
            this.discountCheck.Margin = new System.Windows.Forms.Padding(2);
            this.discountCheck.Name = "discountCheck";
            this.discountCheck.Size = new System.Drawing.Size(97, 17);
            this.discountCheck.TabIndex = 39;
            this.discountCheck.Text = "Apply Discount";
            this.discountCheck.UseVisualStyleBackColor = true;
            // 
            // itemIDcbox
            // 
            this.itemIDcbox.DisplayMember = "itemID";
            this.itemIDcbox.FormattingEnabled = true;
            this.itemIDcbox.Location = new System.Drawing.Point(196, 50);
            this.itemIDcbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemIDcbox.Name = "itemIDcbox";
            this.itemIDcbox.Size = new System.Drawing.Size(138, 21);
            this.itemIDcbox.TabIndex = 38;
            this.itemIDcbox.SelectedIndexChanged += new System.EventHandler(this.itemIDcbox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(306, 206);
            this.dataGridView1.TabIndex = 37;
            // 
            // itemNameT
            // 
            this.itemNameT.Location = new System.Drawing.Point(196, 95);
            this.itemNameT.Margin = new System.Windows.Forms.Padding(2);
            this.itemNameT.Name = "itemNameT";
            this.itemNameT.Size = new System.Drawing.Size(138, 20);
            this.itemNameT.TabIndex = 36;
            // 
            // cashierProperties
            // 
            this.cashierProperties.Controls.Add(this.button4);
            this.cashierProperties.Controls.Add(this.button3);
            this.cashierProperties.Controls.Add(this.button2);
            this.cashierProperties.Controls.Add(this.posB);
            this.cashierProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.cashierProperties.Location = new System.Drawing.Point(0, 0);
            this.cashierProperties.Name = "cashierProperties";
            this.cashierProperties.Size = new System.Drawing.Size(772, 43);
            this.cashierProperties.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(520, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Couriers";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(413, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Customers";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pre Orders";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // posB
            // 
            this.posB.Location = new System.Drawing.Point(171, 10);
            this.posB.Name = "posB";
            this.posB.Size = new System.Drawing.Size(75, 23);
            this.posB.TabIndex = 0;
            this.posB.Text = "POS";
            this.posB.UseVisualStyleBackColor = true;
            // 
            // cashierTrashmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 521);
            this.Controls.Add(this.cashierMainP);
            this.Name = "cashierTrashmain";
            this.Text = "cashierTrashmain";
            this.cashierMainP.ResumeLayout(false);
            this.posP.ResumeLayout(false);
            this.posP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quntityNMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cashierProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cashierMainP;
        private System.Windows.Forms.Panel cashierProperties;
        private System.Windows.Forms.Button posB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel posP;
        private System.Windows.Forms.ComboBox manufacturercbox;
        private System.Windows.Forms.NumericUpDown quntityNMD;
        private System.Windows.Forms.CheckBox discountCheck;
        private System.Windows.Forms.ComboBox itemIDcbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox itemNameT;
        private System.Windows.Forms.Label posPlabel5;
        private System.Windows.Forms.Label posPlabel4;
        private System.Windows.Forms.Label posPlabel3;
        private System.Windows.Forms.Label posPlabel2;
        private System.Windows.Forms.Label posPlabel1;
        private System.Windows.Forms.Button posPdiscardBill;
        private System.Windows.Forms.Button posPpay;
        private System.Windows.Forms.Button posPadd;
    }
}