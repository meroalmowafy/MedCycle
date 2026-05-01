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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnPatient = new Button();
            btnPharmacist = new Button();
            txtPassword = new TextBox();
            btnDonor = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnPatient
            // 
            btnPatient.BackColor = Color.SteelBlue;
            btnPatient.FlatStyle = FlatStyle.Flat;
            btnPatient.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatient.ForeColor = Color.White;
            btnPatient.Location = new Point(337, 269);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(274, 58);
            btnPatient.TabIndex = 0;
            btnPatient.Text = "Enter as Patient ";
            btnPatient.UseVisualStyleBackColor = false;
            btnPatient.Click += btnPatient_Click;
            // 
            // btnPharmacist
            // 
            btnPharmacist.BackColor = Color.SteelBlue;
            btnPharmacist.FlatStyle = FlatStyle.Flat;
            btnPharmacist.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPharmacist.ForeColor = Color.White;
            btnPharmacist.Location = new Point(337, 469);
            btnPharmacist.Name = "btnPharmacist";
            btnPharmacist.Size = new Size(274, 58);
            btnPharmacist.TabIndex = 1;
            btnPharmacist.Text = "Enter as Pharmacist";
            btnPharmacist.UseVisualStyleBackColor = false;
            btnPharmacist.Click += btnPharmacist_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(467, 546);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 2;
            // 
            // btnDonor
            // 
            btnDonor.BackColor = Color.SteelBlue;
            btnDonor.FlatStyle = FlatStyle.Flat;
            btnDonor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonor.ForeColor = Color.White;
            btnDonor.Location = new Point(337, 370);
            btnDonor.Name = "btnDonor";
            btnDonor.Size = new Size(274, 58);
            btnDonor.TabIndex = 3;
            btnDonor.Text = "Enter as Donor / Seller";
            btnDonor.UseVisualStyleBackColor = false;
            btnDonor.Click += btnDonor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(354, 549);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "Password :";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(932, 603);
            Controls.Add(label2);
            Controls.Add(btnDonor);
            Controls.Add(txtPassword);
            Controls.Add(btnPharmacist);
            Controls.Add(btnPatient);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Label label2;
    }
}