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
        string query = string.Empty;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            query = "Categories";
            FrmQuery frmQuery = new FrmQuery(query);
            frmQuery.ShowDialog();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            query = "Employees";
            FrmQuery frmQuery = new FrmQuery(query);
            frmQuery.ShowDialog();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            query = "Products";
            FrmQuery frmQuery = new FrmQuery(query);
            frmQuery.ShowDialog();
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            query = "Suppliers";
            FrmQuery frmQuery = new FrmQuery(query);
            frmQuery.ShowDialog();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            // FrmCustomers frmCustomers = new FrmCustomers();
            //frmCustomers.ShowDialog();
            query = "Customers";
            FrmQuery frmQuery = new FrmQuery(query);
            frmQuery.ShowDialog();
        }

        private void buttonTerritories_Click(object sender, EventArgs e)
        {
            query = "Territories";
            FrmQuery frmQuery = new FrmQuery(query);
            frmQuery.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
