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
        // 1. المتغير الجديد اللي هيشيل الحالة
        MedStatus incomingStatus;

        //هنا لو المستخدم جاي من شاشه اللوج ان
        public DonorForm()
        {
            InitializeComponent();
        }

        //هنا لو المستخدم جاي من شاشه الرساله
        public DonorForm(string medName, int pillsLeft, DateTime expiry, MedStatus status)
        {
            InitializeComponent();

            // 1. الداتا تتكتب وتتقفل 
            txtMedName.Text = medName;
            numPills.Value = pillsLeft;
            dtpExpiry.Value = expiry;
            txtMedName.Enabled = false;
            numPills.Enabled = false;
            dtpExpiry.Enabled = false;

            // 2. نعلم على الاختيار الصح حسب اللي اختاره في الرسالة
            if (status == MedStatus.DirectDonation)
            {
                radDonate.Checked = true;
            }
            else if (status == MedStatus.DiscountedSale)
            {
                radSell.Checked = true;
            }

            // 3. نقفل الاختيارين )
            radDonate.Enabled = false;
            radSell.Enabled = false;
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {

            // 1. التأكد إن اسم الدواء مش فاضي
            if (string.IsNullOrWhiteSpace(txtMedName.Text))
            {
                MessageBox.Show("Please enter the medication name.");
                return;
            }

            MedStatus finalStatus;

            if (radDonate.Checked == true)
            {
                finalStatus = MedStatus.DirectDonation;
            }
            else
            {
                finalStatus = MedStatus.DiscountedSale;
            }
            

            
          
            // 2. إنشاء كائن الدواء بالبيانات الجديدة
            Medication newMed = new Medication
            {
                Name = txtMedName.Text, //اسم الدواء
                DonorName = txtDonorName.Text, // اسم التبرع
                DonorPhone = txtDonorPhone.Text, // رقم هاتف التبرع
                PillsCount = (int)numPills.Value, // عدد الحبوب
                ExpiryDate = dtpExpiry.Value, // تاريخ الانتهاء
                Status = finalStatus // الحالة النهائية
            };

            // 3. إضافة الدواء لقائمة التبرعات
            GlobalData.DonatedMedications.Add(newMed);

            // رسالة ديناميكية بتتغير حسب اختيار المستخدم
            if (radDonate.Checked == true)
            {
                MessageBox.Show("Thank you for your generous donation!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your medication has been successfully listed for sale!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // نفضي المربعات عشان الدواء الجديد
            txtMedName.Clear();
            txtDonorName.Clear();   // نفضي اسم المتبرع
            txtDonorPhone.Clear();  // نفضي رقم المتبرع
            numPills.Value = 1;     // نرجع القيمة لـ 1
            numPills.Enabled = true;     // فتح عداد الحبوب
            dtpExpiry.Enabled = true;         // فتح النتيجة بتاعت التاريخ
            txtMedName.Enabled = true;
            radDonate.Enabled = true;
            radSell.Enabled = true;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
