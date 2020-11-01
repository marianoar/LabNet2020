using Lab.Logic;
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
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
            buttonAlta.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            SupplierLogic supplierLogic = new SupplierLogic();
            var suppliers = supplierLogic.Suppliers();
            for (int i = 0; i < suppliers.Count(); i++)
            {
                listBoxSupplies.Items.Add(suppliers[i]);
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
