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

                // تخلي الأعمدة تملأ عرض الشاشة بالكامل
                dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        
    }

}
