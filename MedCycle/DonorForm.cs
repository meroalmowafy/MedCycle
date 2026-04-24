using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedCycle
{
    public partial class DonorForm : Form
    {
        public DonorForm()
        {
            InitializeComponent();
        }

        public DonorForm(string medName, int pillsLeft, DateTime expiry)
        {
            InitializeComponent();

            // نكتب الداتا اللي جاتلنا من المريض في المربعات أوتوماتيك
            txtMedName.Text = medName;
            numPills.Value = pillsLeft;
            dtpExpiry.Value = expiry;

            //  نقفل المربعات دي عشان المريض مايلعبش فيها ويغير الحسابات
            txtMedName.Enabled = false;
            numPills.Enabled = false;
            dtpExpiry.Enabled = false;
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {

            // 1. التأكد إن اسم الدواء مش فاضي
            if (string.IsNullOrWhiteSpace(txtMedName.Text))
            {
                MessageBox.Show("Please enter the medication name.");
                return;
            }

            // 2. إنشاء كائن الدواء بالبيانات الجديدة
            Medication newMed = new Medication
            {
                Name = txtMedName.Text,
                DonorName = txtDonorName.Text, // اسم التبرع
                DonorPhone = txtDonorPhone.Text, // رقم هاتف التبرع
                PillsCount = (int)numPills.Value,
                ExpiryDate = dtpExpiry.Value,
                Status = MedStatus.DirectDonation
            };

            // 3. إضافة الدواء لقائمة التبرعات
            GlobalData.DonatedMedications.Add(newMed);

            MessageBox.Show($"Thank you! You've donated {newMed.PillsCount} pills of {newMed.Name}.");

            // نفضي المربعات عشان الدواء الجديد
            txtMedName.Clear();
            txtDonorName.Clear();   // نفضي اسم المتبرع
            txtDonorPhone.Clear();  // نفضي رقم المتبرع
            numPills.Value = 1;     // نرجع القيمة لـ 1


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
