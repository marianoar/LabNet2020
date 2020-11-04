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
    public partial class FrmQuery: Form
    { 
        string thisQuery;
        public FrmQuery(string query) : this()
        {
            labelTitle.Text = query;
            this.thisQuery = query;
           
            if (query == "Employees")
            {
                buttonAlta.Enabled = true;
                buttonModificar.Enabled = true;
            }
            else
            {
                buttonAlta.Enabled = false;
                buttonModificar.Enabled = false;

            }

            if((query== "Employees") || (query=="Categories") || (query == "Customers"))
            {
                buttonEliminar.Enabled = true;
            }
            else
            {
                buttonEliminar.Visible = false;
                buttonAlta.Visible = false;
                buttonModificar.Visible = false;
            }

        }
        public FrmQuery()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            listBoxQuery.Items.Clear();
            try
            {
                switch (thisQuery)
                {
                    case "Categories":
                        CategoryLogic categoriesLogic = new CategoryLogic();
                        var categories = categoriesLogic.GetAll();

                        for (int i = 0; i < categories.Count(); i++)
                        {
                            listBoxQuery.Items.Add(categories[i].ToString());
                        }
                        break;

                    case "Employees":
                        EmployeeLogic employeesLogic = new EmployeeLogic();
                        var employees = employeesLogic.GetAll();
                        for (int i = 0; i < employees.Count(); i++)
                        {
                            listBoxQuery.Items.Add(employees[i].ToString());
                        }
                        break;

                    case "Customers":
                        CustomerLogic customerLogic = new CustomerLogic();
                        var customers = customerLogic.GetAll();
                        for (int i = 0; i < customers.Count(); i++)
                        {
                            listBoxQuery.Items.Add(customers[i].ToString());
                        }
                        break;

                    case "Products":
                        ProductLogic productLogic = new ProductLogic();
                        var products = productLogic.GetAll();

                        for (int i = 0; i < products.Count(); i++)
                        {
                            listBoxQuery.Items.Add(products[i]);
                        }
                        break;

                    case "Suppliers":
                        SupplierLogic supplierLogic = new SupplierLogic();
                        var suppliers = supplierLogic.GetAll();
                        for (int i = 0; i < suppliers.Count(); i++)
                        {
                            listBoxQuery.Items.Add(suppliers[i]);
                        }
                        break;

                    case "Territories":
                        TerritoriesLogic territoriesLogic = new TerritoriesLogic();
                        var territories = territoriesLogic.GetAll();
                        for (int i = 0; i < territories.Count(); i++)
                        {
                            listBoxQuery.Items.Add(territories[i].ToString());
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (thisQuery)
                {
                    case "Categories":
                        CategoryLogic categoryLogic = new CategoryLogic();
                        var categories = categoryLogic.GetAll();
                        MessageBox.Show(string.Concat("Vamos a eliminar a: \n\n", categories[listBoxQuery.SelectedIndex]).ToString());
                        if (categoryLogic.Delete(categories[listBoxQuery.SelectedIndex]))
                        {
                            MessageBox.Show(string.Concat("Category deleted."));
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error. No se pudo eliminar.");
                        }
                        break;
                    case "Employees":
                        EmployeeLogic employeeLogic = new EmployeeLogic();
                        var employees = employeeLogic.GetAll();
                        if (employeeLogic.Delete(employees[listBoxQuery.SelectedIndex]))
                        {
                            MessageBox.Show(string.Concat("Employee deleted."));
                            listBoxQuery.Items.Clear();
                            employees = employeeLogic.GetAll();
                            for (int i = 0; i < employees.Count(); i++)
                            {
                                listBoxQuery.Items.Add(employees[i].ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error. No se pudo eliminar.");
                        }
                        break;
                    case "Customers":
                        CustomerLogic customerLogic = new CustomerLogic();
                        var customers = customerLogic.GetAll();
                        if(customerLogic.Delete(customers[listBoxQuery.SelectedIndex]))
                        {
                            MessageBox.Show(string.Concat("Customer deleted."));
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error. No se pudo eliminar.");
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error. ¿Seleccionó algun item?");
            }
        }
        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                switch (thisQuery)
                {
                    case "Employees":
                        FrmCreate frmCreate = new FrmCreate();
                        frmCreate.ShowDialog();
                        listBoxQuery.Items.Clear();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado ;)");
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (thisQuery)
                {
                    case "Employees":
                        EmployeeLogic employeeLogic = new EmployeeLogic();
                        var employees = employeeLogic.GetAll();
                        if (employeeLogic.ModifyEmployee(employees[listBoxQuery.SelectedIndex])) 
                            MessageBox.Show("Modificacion exitosa");

                        listBoxQuery.Items.Clear();
                        for (int i = 0; i < employees.Count(); i++)
                        {
                            listBoxQuery.Items.Add(employees[i].ToString());
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado ;)");
            }
        }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
