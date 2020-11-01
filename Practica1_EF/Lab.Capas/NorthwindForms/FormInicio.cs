using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindForms
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.ShowDialog();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            FrmEmployees frmEmployees = new FrmEmployees();
            frmEmployees.ShowDialog();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            FrmProducts frmProducts = new FrmProducts();
            frmProducts.ShowDialog();
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            FrmSuppliers frmSupplies = new FrmSuppliers();
            frmSupplies.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
