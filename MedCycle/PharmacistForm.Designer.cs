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
            btnViewInventory = new Button();
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
            dgvDonations.Size = new Size(908, 363);
            dgvDonations.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(12, 415);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(277, 56);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "View Medications";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.SteelBlue;
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(12, 477);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(277, 56);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept & Add to Inventory";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnViewInventory
            // 
            btnViewInventory.BackColor = Color.SteelBlue;
            btnViewInventory.Cursor = Cursors.Hand;
            btnViewInventory.FlatStyle = FlatStyle.Flat;
            btnViewInventory.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewInventory.ForeColor = Color.White;
            btnViewInventory.Location = new Point(12, 539);
            btnViewInventory.Name = "btnViewInventory";
            btnViewInventory.Size = new Size(277, 56);
            btnViewInventory.TabIndex = 3;
            btnViewInventory.Text = "View Inventory";
            btnViewInventory.UseVisualStyleBackColor = false;
            btnViewInventory.Click += btnViewInventory_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.Cursor = Cursors.Hand;
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
            BackColor = Color.AliceBlue;
            ClientSize = new Size(932, 603);
            Controls.Add(btnLogout);
            Controls.Add(btnViewInventory);
            Controls.Add(btnAccept);
            Controls.Add(btnRefresh);
            Controls.Add(dgvDonations);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button btnViewInventory;
        private Button btnLogout;
    }
}