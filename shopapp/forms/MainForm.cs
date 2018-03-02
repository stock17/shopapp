using shopapp.entities;
using shopapp.presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopapp
{
    public partial class MainForm : Form, ShopAppPresenter.IMainForm
    {
        private ShopAppPresenter presenter;

        private List<Customer> CustomerList;
        private Customer CurrentCustomer;

        private List<Product> ProductList;
        private Product CurrentProduct;

        public MainForm()
        {
            InitializeComponent();
            presenter = new ShopAppPresenter(this);
            presenter.onStart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
               

        public void refreshInfo (List<Customer> customerList, List<Product> productList)
        {
            this.CustomerList = customerList;
            customersListBox.Items.Clear();
            foreach (Customer c in this.CustomerList)
            {
                this.customersListBox.Items.Add(c.Name);
            }

            this.ProductList = productList;
            productsListBox.Items.Clear();
            foreach (Product p in this.ProductList)
            {
                this.productsListBox.Items.Add(p.Name);
            }
        }

        public void showCustomer(Customer customer)
        {
            this.IdTextBox.Text = customer.Id.ToString();
            this.nameTextBox.Text = customer.Name;
            this.sexTextBox.Text = customer.Sex ? "Male" : "Female";
            this.ageTextBox.Text = customer.Age.ToString();
            this.statusTextBox.Text = ((Customer.SocialStatus) customer.Status).ToString();
        }

        public void showProduct(Product product)
        {
            this.productIdTextBox.Text = product.Id.ToString();
            this.productNameTextBox.Text = product.Name;
            this.productPriceTextBox.Text = (product.Price / 100).ToString();
            this.productQuantityTextBox.Text = product.Quantity.ToString();            
        }

        private void EnableSave() {
            saveButton.Enabled = true;
            saveButton.Image = shopapp.Properties.Resources.save_enabled;
        }

        private void DisableSave()
        {
            saveButton.Enabled = false;
            saveButton.Image = shopapp.Properties.Resources.save_disabled;
        }


        #region Button Handlers

        /// ------------------------------------------------------------------- ///
        /// -------------------- BUTTON HANDLERS ------------------------------ ///
        /// ------------------------------------------------------------------- ///


        private void newButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                EditCustomerForm editCustomerForm = new EditCustomerForm();
                if (editCustomerForm.ShowDialog(this) == DialogResult.OK)
                {
                    Customer c = new Customer(editCustomerForm.CustomerName, editCustomerForm.CustomerSex,
                        editCustomerForm.CustomerAge, editCustomerForm.CustomerStatus);
                    presenter.onAddCustomer(c);
                    showCustomer(c);
                    EnableSave();
                }
            }

            else if (tabControl1.SelectedIndex == 1)
            {
                ProductForm productForm = new ProductForm();
                if (productForm.ShowDialog(this) == DialogResult.OK)
                {
                    Product p = new Product(productForm.ProdName, productForm.ProductPrice, productForm.ProductQuantity);
                    presenter.onAddProduct(p);
                    showProduct(p);
                    EnableSave();

                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 && this.CurrentCustomer != null) {
                EditCustomerForm editCustomerForm = new EditCustomerForm(this.CurrentCustomer);
                if (editCustomerForm.ShowDialog(this) == DialogResult.OK)
                {
                    CurrentCustomer.Name = editCustomerForm.CustomerName;
                    CurrentCustomer.Sex = editCustomerForm.CustomerSex;
                    CurrentCustomer.Age = editCustomerForm.CustomerAge;
                    CurrentCustomer.Status = editCustomerForm.CustomerStatus;
                    
                    int CurrentIndex = customersListBox.SelectedIndex;
                    presenter.OnEditCustomer(CurrentCustomer, CurrentIndex);
                    showCustomer(CurrentCustomer);
                    EnableSave();

                }

            }

            else if (tabControl1.SelectedIndex == 1 && this.CurrentProduct != null)
            {
                ProductForm productForm = new ProductForm(this.CurrentProduct);
                if (productForm.ShowDialog(this) == DialogResult.OK)
                {
                    CurrentProduct.Name = productForm.ProdName;
                    CurrentProduct.Price = productForm.ProductPrice;
                    CurrentProduct.Quantity = productForm.ProductQuantity;
                    
                    int CurrentIndex = productsListBox.SelectedIndex;
                    presenter.OnEditProduct(CurrentProduct, CurrentIndex);
                    showProduct(CurrentProduct);
                    EnableSave();
                }

            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 && this.CurrentCustomer != null)
            {                    
                int CurrentIndex = customersListBox.SelectedIndex;                
                presenter.OnRemoveCustomer(CurrentIndex);
                CurrentCustomer = null;
                EnableSave();
            }
        }

        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = customersListBox.SelectedIndex;
            if (index > -1)
            {
                this.CurrentCustomer = this.CustomerList[index];
                presenter.OnCustomerSelected(this.CurrentCustomer);
            }
        }

        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = productsListBox.SelectedIndex;
            if (index > -1)
            {
                this.CurrentProduct = this.ProductList[index];
                presenter.OnProductSelected(this.CurrentProduct);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            presenter.onSave();
            DisableSave();
        }

        #endregion


    }
}
