namespace MedCycle
{
    partial class LoginForm
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
            btnPatient = new Button();
            btnPharmacist = new Button();
            txtPassword = new TextBox();
            btnDonor = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPatient
            // 
            btnPatient.BackColor = Color.Teal;
            btnPatient.FlatStyle = FlatStyle.Flat;
            btnPatient.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatient.ForeColor = Color.White;
            btnPatient.Location = new Point(349, 165);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(238, 58);
            btnPatient.TabIndex = 0;
            btnPatient.Text = "Enter as Patient ";
            btnPatient.UseVisualStyleBackColor = false;
            btnPatient.Click += btnPatient_Click;
            // 
            // btnPharmacist
            // 
            btnPharmacist.BackColor = Color.Teal;
            btnPharmacist.FlatStyle = FlatStyle.Flat;
            btnPharmacist.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPharmacist.ForeColor = Color.White;
            btnPharmacist.Location = new Point(350, 391);
            btnPharmacist.Name = "btnPharmacist";
            btnPharmacist.Size = new Size(237, 58);
            btnPharmacist.TabIndex = 1;
            btnPharmacist.Text = "Enter as Pharmacist";
            btnPharmacist.UseVisualStyleBackColor = false;
            btnPharmacist.Click += btnPharmacist_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(403, 358);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 2;
            // 
            // btnDonor
            // 
            btnDonor.BackColor = Color.Teal;
            btnDonor.FlatStyle = FlatStyle.Flat;
            btnDonor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonor.ForeColor = Color.White;
            btnDonor.Location = new Point(349, 260);
            btnDonor.Name = "btnDonor";
            btnDonor.Size = new Size(238, 58);
            btnDonor.TabIndex = 3;
            btnDonor.Text = "Enter as Donor";
            btnDonor.UseVisualStyleBackColor = false;
            btnDonor.Click += btnDonor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(254, 61);
            label1.Name = "label1";
            label1.Size = new Size(446, 54);
            label1.TabIndex = 4;
            label1.Text = "Welcome To MedCycle";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 524);
            Controls.Add(label1);
            Controls.Add(btnDonor);
            Controls.Add(txtPassword);
            Controls.Add(btnPharmacist);
            Controls.Add(btnPatient);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPatient;
        private Button btnPharmacist;
        private TextBox txtPassword;
        private Button btnDonor;
        private Label label1;
    }
}