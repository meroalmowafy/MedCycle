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
            if (dgvInventory.Columns.Count > 0)
            {
                dgvInventory.Columns["Interval"].Visible = false;
                dgvInventory.Columns["Duration"].Visible = false;
                dgvInventory.Columns["DonorName"].Visible = false;
                dgvInventory.Columns["DonorPhone"].Visible = false;

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
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int index = dgvInventory.SelectedRows[0].Index;
                GlobalData.PharmacyInventory.RemoveAt(index);

                dgvInventory.DataSource = GlobalData.PharmacyInventory;
                MessageBox.Show("Medication has been removed from inventory", "Success!");
            }
            else
            {
                MessageBox.Show("Please select the midication that you need to remove", "Error!");
            }
            dgvInventory.ClearSelection();
            dgvInventory.CurrentCell = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string textsearch = txtSearch.Text;
            var filterlist = GlobalData.PharmacyInventory.Where(x => x.Name.ToLower().Contains(textsearch)).ToList();
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = filterlist;

            if (dgvInventory.Columns.Count > 0)
            {
                dgvInventory.Columns["Interval"].Visible = false;
                dgvInventory.Columns["Duration"].Visible = false;
                dgvInventory.Columns["DonorName"].Visible = false;
                dgvInventory.Columns["DonorPhone"].Visible = false;
                dgvInventory.Columns["ReminderHours"].Visible = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = GlobalData.PharmacyInventory;
            if (dgvInventory.Columns.Count > 0)
            {
                dgvInventory.Columns["Interval"].Visible = false;
                dgvInventory.Columns["Duration"].Visible = false;
                dgvInventory.Columns["DonorName"].Visible = false;
                dgvInventory.Columns["DonorPhone"].Visible = false;
                dgvInventory.Columns["ReminderHours"].Visible = false;


            }
            dgvInventory.ClearSelection();
            dgvInventory.CurrentCell = null;
        }

        private void dgvInventory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }

}
