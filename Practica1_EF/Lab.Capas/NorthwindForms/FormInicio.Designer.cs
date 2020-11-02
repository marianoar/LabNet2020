namespace NorthwindForms
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonTerritories = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(60, 80);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(100, 100);
            this.buttonCategories.TabIndex = 0;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Location = new System.Drawing.Point(173, 80);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(100, 100);
            this.buttonEmployees.TabIndex = 1;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(60, 186);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(100, 100);
            this.buttonProducts.TabIndex = 4;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.Location = new System.Drawing.Point(173, 187);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(100, 100);
            this.buttonSuppliers.TabIndex = 5;
            this.buttonSuppliers.Text = "Suppliers";
            this.buttonSuppliers.UseVisualStyleBackColor = true;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(168, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(108, 25);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Northwind";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(173, 317);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonTerritories
            // 
            this.buttonTerritories.Location = new System.Drawing.Point(286, 187);
            this.buttonTerritories.Name = "buttonTerritories";
            this.buttonTerritories.Size = new System.Drawing.Size(100, 100);
            this.buttonTerritories.TabIndex = 6;
            this.buttonTerritories.Text = "Territories";
            this.buttonTerritories.UseVisualStyleBackColor = true;
            this.buttonTerritories.Click += new System.EventHandler(this.buttonTerritories_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Location = new System.Drawing.Point(286, 80);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(100, 100);
            this.buttonCustomers.TabIndex = 3;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 361);
            this.Controls.Add(this.buttonTerritories);
            this.Controls.Add(this.buttonCustomers);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSuppliers);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonCategories);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab .Net Oct 2020 : Practica EF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonTerritories;
        private System.Windows.Forms.Button buttonCustomers;
    }
}

