using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab.Logic;
using Lab.Capas.Entities;

namespace NorthwindForms
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
            buttonAlta.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            var categories = categoriesLogic.Categories();
            //var categoriesA = categoriesLogic.Categories(2);
           // MessageBox.Show(categoriesA.ToString());

            listBoxCategories.Items.Clear();
            for (int i = 0; i<categories.Count(); i++)
            {
                listBoxCategories.Items.Add(categories[i].ToString());
            }
        }

        private void ListarEntidades()
        {
           
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
