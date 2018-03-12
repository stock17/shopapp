using shopapp.entities;
using shopapp.forms;
using shopapp.localization;
using shopapp.presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopapp
{
    public partial class MainForm : Form, ShopAppPresenter.IMainForm, ILanguageChangeable
    {
        private ShopAppPresenter presenter;

        private List<Customer> CustomerList;
        private Customer CurrentCustomer;

        private List<Product> ProductList;
        private Product CurrentProduct;

        private List<Order> OrderList;
        private Order CurrentOrder;

        public MainForm()
        {
            InitializeComponent();
            presenter = new ShopAppPresenter(this);
            presenter.onStart();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeFormLanguage(LanguageSettings.CurrentLanguage);
        }
               

        public void refreshInfo (List<Customer> customerList, List<Product> productList, List<Order> orderList)
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

            this.OrderList = orderList;
            ordersListBox.Items.Clear();

            foreach (Order o in this.OrderList)
            {
                string text = o.OrderCustomer != null ? o.OrderCustomer.Name : "removed";
                text = text + " " + o.Date.ToString();
                for (int i = 0; i < o.ProductList.ProductList.Count; i++) {
                    text = text + " " + o.ProductList.ProductList[i].Name;
                    text = text + " - " + o.ProductList.QuantityList[i];
                }

                this.ordersListBox.Items.Add(text);
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
        }

        public void ShowReport(List<Order> orders)
        {
            //TODO
            ResultReportForm form = new ResultReportForm(orders);
            form.ShowDialog(this);
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
                    Product p = new Product(productForm.ProdName, productForm.ProductPrice);
                    presenter.onAddProduct(p);
                    showProduct(p);
                    EnableSave();

                }
            }

            else if (tabControl1.SelectedIndex == 2)
            {
                OrderForm orderForm = new OrderForm(CustomerList, ProductList);
                if (orderForm.ShowDialog(this) == DialogResult.OK)
                {
                    OrderProductList list = new OrderProductList(orderForm.newOrderProductList, orderForm.newOrderQuantityProductList);
                    int customerIndex = orderForm.CustomerIndex;
                    Order order = new Order(CustomerList[customerIndex], list, orderForm.datePickerValue);
                    presenter.onAddOrder(order, list);
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
                    
                    
                    int CurrentIndex = productsListBox.SelectedIndex;
                    presenter.OnEditProduct(CurrentProduct, CurrentIndex);
                    showProduct(CurrentProduct);
                    EnableSave();
                }

            }

        }

        /// -------------------- REMOVE BUTTON ----------------------------------///

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 && this.CurrentCustomer != null)
            {                    
                int CurrentIndex = customersListBox.SelectedIndex;                
                presenter.OnRemoveCustomer(CurrentIndex);
                CurrentCustomer = null;
                EnableSave();
            }

            else if (tabControl1.SelectedIndex == 1 && this.CurrentProduct != null)
            {
                int CurrentIndex = productsListBox.SelectedIndex;
                presenter.OnRemoveProduct(CurrentIndex);
                CurrentProduct = null;
                EnableSave();
            }

            else if  (tabControl1.SelectedIndex == 2 && this.CurrentOrder != null)
            {
                int CurrentIndex = ordersListBox.SelectedIndex;
                presenter.OnRemoveOrder(CurrentIndex);
                CurrentOrder = null;
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

        private void ordersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox box = (ListBox)sender;
            CurrentOrder = OrderList[box.SelectedIndex];
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            RequestReportForm reportForm = new RequestReportForm(CustomerList, ProductList);
                if (reportForm.ShowDialog(this) == DialogResult.OK)
                {
                presenter.OnRequestReport(
                    reportForm.ReportCustomerList,
                    reportForm.FromAge,
                    reportForm.ToAge,
                    reportForm.StatusList,
                    reportForm.ReportProductList,
                    reportForm.FromDate,
                    reportForm.ToDate);
                }
            
        }

        private void fakeBDButton_Click(object sender, EventArgs e)
        {
            presenter.OnGenerateFakeBD();
            EnableSave();
        }

        // TODO Rewrite with recursion
        public void ChangeFormLanguage(string newLocalization)
        {
            var resources = new ComponentResourceManager(this.GetType());
            CultureInfo newCultureInfo = new CultureInfo(newLocalization);

            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, newCultureInfo);
                if (c.Controls.Count != 0)
                {
                    foreach (Control c1 in c.Controls)
                    {
                        resources.ApplyResources(c1, c1.Name, newCultureInfo);
                        if (c1.Controls.Count != 0) {
                            foreach (Control c2 in c1.Controls) {
                                resources.ApplyResources(c2, c2.Name, newCultureInfo);
                            }
                        }
                    }
                }                
            }

            resources.ApplyResources(this, "$this", newCultureInfo);
        }

        



        private void changeLanguageButton_Click(object sender, EventArgs e)
        {
            if (LanguageSettings.CurrentLanguage.Equals(LanguageSettings.ENGLISH))
            {
                LanguageSettings.CurrentLanguage = LanguageSettings.RUSSIAN;
            }
            else
            {
                LanguageSettings.CurrentLanguage = LanguageSettings.ENGLISH;
            }

            ChangeFormLanguage(LanguageSettings.CurrentLanguage);
        }
    }
}
