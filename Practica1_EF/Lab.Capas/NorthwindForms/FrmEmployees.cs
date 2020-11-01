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
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
            buttonAlta.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();
            var employees = employeesLogic.Employees();
            for(int i = 0; i < employees.Count(); i++)
            {
                listBoxEmployees.Items.Add(employees[i].ToString());
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
