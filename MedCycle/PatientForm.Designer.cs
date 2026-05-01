namespace MedCycle
{
    partial class PatientForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMedName = new TextBox();
            numInterval = new NumericUpDown();
            dtpExpiry = new DateTimePicker();
            btnAddMed = new Button();
            reminderTimer = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            numCourseDays = new NumericUpDown();
            label6 = new Label();
            numTotalPills = new NumericUpDown();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCourseDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalPills).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(255, 35);
            label1.Name = "label1";
            label1.Size = new Size(421, 46);
            label1.TabIndex = 0;
            label1.Text = "Register New Medication";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 113);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 1;
            label2.Text = "Drug Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 265);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 2;
            label3.Text = "Interval (Hours)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(104, 414);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 3;
            label4.Text = "Expiry Date";
            // 
            // txtMedName
            // 
            txtMedName.Location = new Point(104, 141);
            txtMedName.Name = "txtMedName";
            txtMedName.Size = new Size(125, 27);
            txtMedName.TabIndex = 4;
            // 
            // numInterval
            // 
            numInterval.Location = new Point(104, 293);
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(150, 27);
            numInterval.TabIndex = 5;
            numInterval.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // dtpExpiry
            // 
            dtpExpiry.Location = new Point(104, 442);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(250, 27);
            dtpExpiry.TabIndex = 6;
            // 
            // btnAddMed
            // 
            btnAddMed.BackColor = Color.SteelBlue;
            btnAddMed.Cursor = Cursors.Hand;
            btnAddMed.FlatAppearance.BorderSize = 0;
            btnAddMed.FlatStyle = FlatStyle.Flat;
            btnAddMed.ForeColor = Color.White;
            btnAddMed.Location = new Point(312, 500);
            btnAddMed.Name = "btnAddMed";
            btnAddMed.Size = new Size(311, 77);
            btnAddMed.TabIndex = 7;
            btnAddMed.Text = "Add Medication & Start Reminder";
            btnAddMed.UseVisualStyleBackColor = false;
            btnAddMed.Click += btnAddMed_Click;
            // 
            // reminderTimer
            // 
            reminderTimer.Tick += reminderTimer_Tick_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(103, 342);
            label5.Name = "label5";
            label5.Size = new Size(210, 25);
            label5.TabIndex = 8;
            label5.Text = "Course Duration (Days)";
            // 
            // numCourseDays
            // 
            numCourseDays.Location = new Point(104, 370);
            numCourseDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCourseDays.Name = "numCourseDays";
            numCourseDays.Size = new Size(150, 27);
            numCourseDays.TabIndex = 9;
            numCourseDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(104, 190);
            label6.Name = "label6";
            label6.Size = new Size(146, 23);
            label6.TabIndex = 10;
            label6.Text = "Total Pills in Box ";
            // 
            // numTotalPills
            // 
            numTotalPills.Location = new Point(103, 216);
            numTotalPills.Name = "numTotalPills";
            numTotalPills.Size = new Size(150, 27);
            numTotalPills.TabIndex = 11;
            numTotalPills.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.FlatStyle = FlatStyle.Flat;
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
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(932, 603);
            Controls.Add(btnBack);
            Controls.Add(numTotalPills);
            Controls.Add(label6);
            Controls.Add(numCourseDays);
            Controls.Add(label5);
            Controls.Add(btnAddMed);
            Controls.Add(dtpExpiry);
            Controls.Add(numInterval);
            Controls.Add(txtMedName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedCycle - Patient Dashboard";
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCourseDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalPills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMedName;
        private NumericUpDown numInterval;
        private DateTimePicker dtpExpiry;
        private Button btnAddMed;
        private System.Windows.Forms.Timer reminderTimer;
        private Label label5;
        private NumericUpDown numCourseDays;
        private Label label6;
        private NumericUpDown numTotalPills;
        private Button btnBack;
    }
}