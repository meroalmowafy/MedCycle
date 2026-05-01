using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedCycle
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = GlobalData.PharmacyInventory;// ربط الجدول بالمخزن الجديد
                                                                   // إخفاء الأعمدة اللي مش محتاجينها في شاشة المخزن
            if (dgvInventory.Columns.Count > 0)
            {
                dgvInventory.Columns["Status"].Visible = false;
                dgvInventory.Columns["ReminderHours"].Visible = false;
                dgvInventory.Columns["Interval"].Visible = false;
                dgvInventory.Columns["Duration"].Visible = false;

                // تخلي الأعمدة تملأ عرض الشاشة بالكامل
                dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // 1. نفتح شاشة الصيدلي من جديد
            PharmacistForm phForm = new PharmacistForm();
            phForm.Show();

            // 2. نقفل شاشة المخزن الحالية
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. بنتأكد الأول إن الجدول فيه صفوف متحددة
            if (dgvInventory.SelectedRows.Count > 0)
            {
                // 2. بنتأكد إن الصف المتحدد ده مش الصف الفاضي الأخير (New Row)
                if (dgvInventory.SelectedRows[0].IsNewRow)
                {
                    return; // لو داس على الصف الفاضي، الكود يقف وميعملش حاجة
                }

                // 3. نطلع رسالة التأكيد بعد ما اتأكدنا إن في دواء حقيقي متحدد
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // بنجيب العنصر ونمسحه
                    Medication selectedMed = (Medication)dgvInventory.SelectedRows[0].DataBoundItem;

                    // شرط أمان إضافي عشان لو العنصر مش موجود
                    if (selectedMed != null)
                    {
                        GlobalData.PharmacyInventory.Remove(selectedMed);

                        // تحديث الجدول
                        dgvInventory.DataSource = null;
                        dgvInventory.DataSource = GlobalData.PharmacyInventory;
                    }
                }
            }
            else
            {
                // لو داس على الزرار والجدول فاضي أو مش محدد حاجة
                MessageBox.Show("Please select an item from the table first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            // لو مربع البحث فاضي، بنعرض كل البيانات اللي في اللیست الأصلية
            if (string.IsNullOrEmpty(searchText))
            {
                dgvInventory.DataSource = null;
                dgvInventory.DataSource = GlobalData.PharmacyInventory;
            }
            else
            {
                // بنعمل قائمة جديدة مؤقتة نشيل فيها نتائج البحث
                List<Medication> searchResults = new List<Medication>();

                // بنلف على كل الأدوية اللي في المخزن
                foreach (Medication med in GlobalData.PharmacyInventory)
                {
                    //  "Name" باسم المتغير اللي بيمثل اسم الدواء في كلاس Medication
                    if (med.Name != null && med.Name.ToLower().Contains(searchText))
                    {
                        searchResults.Add(med);
                    }
                }

                // بنعمل تفريغ للجدول الأول وبعدين نعرض فيه نتائج البحث
                dgvInventory.DataSource = null;
                dgvInventory.DataSource = searchResults;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // بنفضي مربع البحث عشان نلغي أي بحث قديم
            txtSearch.Text = "";

            // بنفضي الجدول الأول
            dgvInventory.DataSource = null;

            // بنخليه يعرض كل البيانات اللي في المخزن من تاني
            dgvInventory.DataSource = GlobalData.PharmacyInventory;
        }
    }

}
