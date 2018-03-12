using shopapp.entities;
using shopapp.localization;
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

namespace shopapp.forms
{
    public partial class OrderForm : Form
    {
        private int productIndex;
        private List<Product> OrderProductList;
        


        public List<Product> newOrderProductList { set; get; }
        public List<int> newOrderQuantityProductList { set; get; }
        
        public OrderForm()
        {
            InitializeComponent();         
        }
        public OrderForm(List<Customer> customerList, List<Product> productList)
        {
            InitializeComponent();

            newOrderProductList = new List<Product>();
            newOrderQuantityProductList = new List<int>();

            OrderProductList = productList;          


            customerListOrderFormComboBox.DataSource = customerList.Select(info => info.Name).ToList();
            productListOrderFormComboBox.DataSource = productList;            

        }

              
                
        public int CustomerIndex {            
            get { return customerListOrderFormComboBox.SelectedIndex; }
        }        

        public DateTime datePickerValue {            
            get { return this.dateTimePicker.Value;  }
        }

        

        private void addProductOrderFormButton_Click(object sender, EventArgs e)
        {
            Product product = OrderProductList[productIndex];

            AddProductForm addProductForm = new AddProductForm(product);
            if (addProductForm.ShowDialog(this) == DialogResult.OK)
            {                
                int quantity = addProductForm.Quantity;
                this.produstListOrderFormListBox.Items.Add(product.Name + " " + quantity.ToString() + " pc");

                newOrderProductList.Add(product);
                newOrderQuantityProductList.Add(quantity);
            }
        }

        private void productListOrderFormComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productIndex = ((ComboBox)sender).SelectedIndex;
        }

        public void ChangeFormLanguage(string newLocalization)
        {
            var resources = new ComponentResourceManager(this.GetType());
            CultureInfo newCultureInfo = new CultureInfo(newLocalization);

            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, newCultureInfo);
            }

            resources.ApplyResources(this, "$this", newCultureInfo);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ChangeFormLanguage(LanguageSettings.CurrentLanguage);
        }
    }

    
}
