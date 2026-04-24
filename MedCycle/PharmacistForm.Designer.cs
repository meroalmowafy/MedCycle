namespace MedCycle
{
    partial class PharmacistForm
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
            dgvDonations = new DataGridView();
            btnRefresh = new Button();
            btnAccept = new Button();
            button1 = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDonations).BeginInit();
            SuspendLayout();
            // 
            // dgvDonations
            // 
            dgvDonations.AllowUserToAddRows = false;
            dgvDonations.AllowUserToDeleteRows = false;
            dgvDonations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonations.Location = new Point(12, 46);
            dgvDonations.Name = "dgvDonations";
            dgvDonations.ReadOnly = true;
            dgvDonations.RowHeadersWidth = 51;
            dgvDonations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonations.Size = new Size(916, 385);
            dgvDonations.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Teal;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(12, 437);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(277, 56);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "View Donated Medications";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Teal;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(12, 499);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(277, 56);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept & Add to Inventory";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 561);
            button1.Name = "button1";
            button1.Size = new Size(277, 56);
            button1.TabIndex = 3;
            button1.Text = "View Inventory";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Teal;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 11);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnBack_Click;
            // 
            // PharmacistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 629);
            Controls.Add(btnLogout);
            Controls.Add(button1);
            Controls.Add(btnAccept);
            Controls.Add(btnRefresh);
            Controls.Add(dgvDonations);
            Name = "PharmacistForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PharmacistForm";
            ((System.ComponentModel.ISupportInitialize)dgvDonations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDonations;
        private Button btnRefresh;
        private Button btnAccept;
        private Button button1;
        private Button btnLogout;
    }
}