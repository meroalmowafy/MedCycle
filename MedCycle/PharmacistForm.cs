using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedCycle
{
    public partial class PharmacistForm : Form
    {
        public PharmacistForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // 1. مسح البيانات القديمة من الجدول (عشان ميتكررش)
            dgvDonations.DataSource = null;

            // 2. ربط الجدول بالصندوق المشترك اللي عملناه في GlobalData
            dgvDonations.DataSource = GlobalData.DonatedMedications;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            // التأكد إن فيه سطر محدد في الجدول
            if (dgvDonations.SelectedRows.Count > 0)
            {
                // 1. تحديد السطر المختار
                int selectedIndex = dgvDonations.SelectedRows[0].Index;

                // 2. سحب بيانات الدواء من قائمة التبرعات
                Medication selectedMed = GlobalData.DonatedMedications[selectedIndex];

                // 3. إضافة الدواء ده لقائمة "المخزن" (Inventory)
                GlobalData.PharmacyInventory.Add(selectedMed);

                // 4. مسح الدواء من قائمة "التبرعات" لأنه خلاص اتقبل
                GlobalData.DonatedMedications.RemoveAt(selectedIndex);

                // 5. تحديث الجدول أمام الصيدلي فوراً
                dgvDonations.DataSource = null;
                dgvDonations.DataSource = GlobalData.DonatedMedications;

                MessageBox.Show($"{selectedMed.Name} has been moved to Pharmacy Inventory!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a medication to accept.");
            }
        }

        private void dgvDonations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            InventoryForm inv = new InventoryForm();
            inv.Show(); // بيفتح شاشة المخزن
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }



}
