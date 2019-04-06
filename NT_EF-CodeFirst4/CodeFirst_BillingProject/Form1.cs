using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_BillingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCity frmCity = new FormCity();
            frmCity.Show();
            this.Hide();
        }

        private void countyDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCounty frmCounty = new FormCounty();
            frmCounty.Show();
            this.Hide();
        }

        private void unitDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnit frmUnit = new FormUnit();
            frmUnit.Show();
            this.Hide();
        }

        private void productDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct frmProduct = new FormProduct();
            frmProduct.Show();
            this.Hide();
        }

        private void customerDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer frmCustomer = new FormCustomer();
            frmCustomer.Show();
            this.Hide();
        }
    }
}
