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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            buttonAlta.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            ProductLogic productLogic = new ProductLogic();
            var products = productLogic.Products();

            for (int i = 0; i < products.Count(); i++)
            {
                listBoxProducts.Items.Add(products[i]);
            }

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
