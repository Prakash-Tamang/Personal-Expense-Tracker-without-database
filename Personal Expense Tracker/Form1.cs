using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set width of "ItemName" column to 80% of the available width
            dgvTableDetails.Columns.Add("ItemName", "Item Name");
            dgvTableDetails.Columns.Add("Amount", "Amount");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            Double amount = double.Parse(txtAmount.Text);

            //Adding data if column name are already given
            dgvTableDetails.Rows.Add(itemName, amount);




            //Adding Data creating column name and adding its value

            txtItemName.Clear();
            txtAmount.Clear();


            txtItemName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTableDetails.Columns["ItemName"].Width = (int)(dgvTableDetails.Width * 0.8);

        }
    }
}
