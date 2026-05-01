namespace MedCycle
{
    partial class DonorForm
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
            label1 = new Label();
            txtMedName = new TextBox();
            label2 = new Label();
            dtpExpiry = new DateTimePicker();
            btnDonate = new Button();
            label3 = new Label();
            numPills = new NumericUpDown();
            label4 = new Label();
            txtDonorName = new TextBox();
            txtDonorPhone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnBack = new Button();
            radSell = new RadioButton();
            radDonate = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numPills).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 230);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 0;
            label1.Text = "Medicine Name :";
            // 
            // txtMedName
            // 
            txtMedName.Location = new Point(106, 261);
            txtMedName.Name = "txtMedName";
            txtMedName.Size = new Size(172, 27);
            txtMedName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 377);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 2;
            label2.Text = "Expiry Date :";
            // 
            // dtpExpiry
            // 
            dtpExpiry.Location = new Point(106, 408);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(250, 27);
            dtpExpiry.TabIndex = 3;
            // 
            // btnDonate
            // 
            btnDonate.BackColor = Color.SteelBlue;
            btnDonate.FlatAppearance.BorderSize = 0;
            btnDonate.FlatStyle = FlatStyle.Flat;
            btnDonate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonate.ForeColor = Color.White;
            btnDonate.Location = new Point(343, 512);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(219, 60);
            btnDonate.TabIndex = 4;
            btnDonate.Text = "Submit";
            btnDonate.UseVisualStyleBackColor = false;
            btnDonate.Click += btnDonate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 303);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 5;
            label3.Text = "Number of Pills :";
            // 
            // numPills
            // 
            numPills.Location = new Point(106, 334);
            numPills.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPills.Name = "numPills";
            numPills.Size = new Size(172, 27);
            numPills.TabIndex = 6;
            numPills.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(270, 26);
            label4.Name = "label4";
            label4.Size = new Size(392, 41);
            label4.TabIndex = 7;
            label4.Text = "Donate / Sell a Medication";
            // 
            // txtDonorName
            // 
            txtDonorName.Location = new Point(106, 112);
            txtDonorName.Name = "txtDonorName";
            txtDonorName.Size = new Size(172, 27);
            txtDonorName.TabIndex = 8;
            // 
            // txtDonorPhone
            // 
            txtDonorPhone.Location = new Point(106, 187);
            txtDonorPhone.Name = "txtDonorPhone";
            txtDonorPhone.Size = new Size(172, 27);
            txtDonorPhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 81);
            label5.Name = "label5";
            label5.Size = new Size(232, 28);
            label5.TabIndex = 10;
            label5.Text = "(Donor / Seller) Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(106, 156);
            label6.Name = "label6";
            label6.Size = new Size(179, 28);
            label6.TabIndex = 11;
            label6.Text = "Contact Number :";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // radSell
            // 
            radSell.AutoSize = true;
            radSell.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radSell.Location = new Point(0, 56);
            radSell.Name = "radSell";
            radSell.Size = new Size(182, 32);
            radSell.TabIndex = 13;
            radSell.Text = "Sell at Discount";
            radSell.UseVisualStyleBackColor = true;
            // 
            // radDonate
            // 
            radDonate.AutoSize = true;
            radDonate.Checked = true;
            radDonate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radDonate.Location = new Point(0, 26);
            radDonate.Name = "radDonate";
            radDonate.Size = new Size(102, 32);
            radDonate.TabIndex = 14;
            radDonate.TabStop = true;
            radDonate.Text = "Donate";
            radDonate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radDonate);
            groupBox1.Controls.Add(radSell);
            groupBox1.Location = new Point(663, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 97);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose Action";
            // 
            // DonorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(932, 603);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtDonorPhone);
            Controls.Add(txtDonorName);
            Controls.Add(label4);
            Controls.Add(numPills);
            Controls.Add(label3);
            Controls.Add(btnDonate);
            Controls.Add(dtpExpiry);
            Controls.Add(label2);
            Controls.Add(txtMedName);
            Controls.Add(label1);
            Name = "DonorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Donate Medication - MedCycle";
            ((System.ComponentModel.ISupportInitialize)numPills).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMedName;
        private Label label2;
        private DateTimePicker dtpExpiry;
        private Button btnDonate;
        private Label label3;
        private NumericUpDown numPills;
        private Label label4;
        private TextBox txtDonorName;
        private TextBox txtDonorPhone;
        private Label label5;
        private Label label6;
        private Button btnBack;
        private RadioButton radSell;
        private RadioButton radDonate;
        private GroupBox groupBox1;
    }
}