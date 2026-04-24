using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedCycle
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientForm pForm = new PatientForm();
            pForm.Show();
            this.Hide();
        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "123") // Simple password check for demonstration purposes
            {
                PharmacistForm phForm = new PharmacistForm();
                phForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password!", "Security", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            DonorForm dForm = new DonorForm();
            dForm.Show();
            this.Hide();
        }
    }
}
