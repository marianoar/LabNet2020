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
    public partial class FrmCreate : Form
    {
        public FrmCreate()
        {
            InitializeComponent();
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string name = textBoxName.Text;
                string lastName = textBoxLastName.Text;
                string adress = textBoxAdress.Text;
                string city = textBoxCountry.Text;
                string country = textBoxCountry.Text;

                EmployeeLogic employeeLogic = new EmployeeLogic();
                employeeLogic.AddEmployee(name, lastName, adress, city, country);
                this.Close();
            }
            else
            {
               // MessageBox.Show("Hay un error. Revise los datos");
            }
        }
        public bool Validar()
        {
            if ((string.IsNullOrWhiteSpace(textBoxName.Text)) || (string.IsNullOrWhiteSpace(textBoxLastName.Text)))
            {
                label1.Visible = true;
                label2.Visible = true;
                return false;
            }
            return true;
   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label1.Text = "Este campo es obligatorio";
            label2.Text = "Este campo es obligatorio";
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
        }

    }
}
