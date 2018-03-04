using shopapp.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopapp.forms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();         
        }
        public OrderForm(List<Customer> customerList, List<Product> productList)
        {
            InitializeComponent();

            ProductListDictionary = new Dictionary<int, int>();
            OrderProductList = productList;          


            customerListOrderFormComboBox.DataSource = customerList.Select(info => info.Name).ToList();
            productListOrderFormComboBox.DataSource = productList;            

        }

        private int productIndex;
        private List<Product> OrderProductList;
        public Dictionary<int, int> ProductListDictionary;
        
                

        public int OrderId { set; get; }
        public Customer customer { set; get; }
        public List<Product> ProductList { set; get; }
        public DateTime date { set; get; }

        

        private void addProductOrderFormButton_Click(object sender, EventArgs e)
        {
            Product product = OrderProductList[productIndex];

            AddProductForm addProductForm = new AddProductForm(product);
            if (addProductForm.ShowDialog(this) == DialogResult.OK)
            {                
                int quantity = addProductForm.Quantity;
                this.produstListOrderFormListBox.Items.Add(product.Name + " " + quantity.ToString() + " pc");

                ProductListDictionary[product.Id] = quantity;
            }
        }

        private void productListOrderFormComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productIndex = ((ComboBox)sender).SelectedIndex;
        }
    }

    
}
