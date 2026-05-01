using System;
using System.Windows.Forms;

namespace MedCycle
{
    public partial class PatientForm : Form
    {
        int remainingDoses = 0;
        Medication currentMed; // عشان التايمر يقدر يشوف الدواء ويتعامل معاه
        public PatientForm()
        {
            InitializeComponent();
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            // سحب البيانات من الشاشة وتخزينها في الدواء
            currentMed = new Medication
            {
                Name = txtMedName.Text, //اسم الدواء
                ExpiryDate = dtpExpiry.Value, //تاريخ الانتهاء
                // سحبنا الأرقام من الأدوات 
                Interval = (int)numInterval.Value, //الفاصل الزمني بين الجرعات
                Duration = (int)numCourseDays.Value, //مدة الكورس

                // إجمالي عدد الحبوب
                PillsCount = (int)numTotalPills.Value,

                Status = MedStatus.PersonalUse
            };

            // 1. Calculations
            decimal totalHours = numCourseDays.Value * 24;
            remainingDoses = (int)(totalHours / numInterval.Value);

            // 2. Success Message
            MessageBox.Show($"Medication Added! Your treatment course contains {remainingDoses} doses.",
                            "MedCycle - Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // 3. Start Timer (3 seconds for testing)
            // -------------------------------------------------------------
            // الكود الحقيقي لتشغيل المنبه بالساعات )
            // int realHours = (int)numInterval.Value;
            // reminderTimer.Interval = realHours * 60 * 60 * 1000; 
            // -------------------------------------------------------------
            reminderTimer.Interval = 3000;
            reminderTimer.Start();
            txtMedName.Clear();
            numTotalPills.Value = 10; // نرجع القيمة الافتراضية
                                    
        }

        private void reminderTimer_Tick_1(object sender, EventArgs e)
        {

            remainingDoses--; // Decrease one dose
            currentMed.PillsCount--; // دي اللي بتنقص حباية فعلية من العلبة مع كل جرعة
            if (remainingDoses > 0)
            {
                // Still have doses
                MessageBox.Show($"Dose Reminder! You have {remainingDoses} doses left in this course.",
                                "MedCycle Reminder",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                // 1. نوقف المنبه عشان الكورس خلص
                reminderTimer.Stop();

                // 2. نسأل المريض سؤال فيه 3 اختيارات
                DialogResult choice = MessageBox.Show(
                    $"Congratulations! You have successfully completed your treatment course.\n\n" +
                    $"You have ({currentMed.PillsCount}) pills left in the box.\n\n" +
                    "• Click [Yes] to Donate them.\n" +
                    "• Click [No] to Sell them at a discount.\n" +
                    "• Click [Cancel] to Keep them.",
                    "MedCycle - Course Finished",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                // 3. نبرمج كل زرار هيعمل إيه
                if (choice == DialogResult.Yes)
                {
                    DonorForm dForm = new DonorForm(currentMed.Name, currentMed.PillsCount, currentMed.ExpiryDate, MedStatus.DirectDonation);
                    dForm.Show();
                    this.Close();
                }
                else if (choice == DialogResult.No)
                {
                    // لو بيع، نفتح نفس الشاشة، بس نبعت MedStatus.DiscountedSale
                    DonorForm dForm = new DonorForm(currentMed.Name, currentMed.PillsCount, currentMed.ExpiryDate, MedStatus.DiscountedSale);
                    dForm.Show();
                    this.Close();
                }
                else if (choice == DialogResult.Cancel)
                {
                    // لو احتفاظ
                    currentMed.Status = MedStatus.PersonalUse;
                    MessageBox.Show("You chose to keep the remaining pills for personal use.", "Kept");
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }

}