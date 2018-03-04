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

            orderProductList = productList;

            customerListOrderFormComboBox.DataSource = customerList.Select(info => info.Name).ToList();
            productListOrderFormComboBox.DataSource = productList.Select(info => info.Name).ToList();

        }

        private int productIndex;

        public int OrderId { set; get; }

        public Customer customer { set; get; }

        public List<Product> ProductList { set; get; }

        public DateTime date { set; get; }

        private List<Product> orderProductList;

        private void addProductOrderFormButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(productListOrderFormComboBox.Text);
            if (addProductForm.ShowDialog(this) == DialogResult.OK)
            {
                Product p = orderProductList[productIndex];
                int q = addProductForm.Quantity;
                this.produstListOrderFormListBox.Items.Add(p.Name + " " + q.ToString());
            }
        }

        private void productListOrderFormComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productIndex = ((ComboBox)sender).SelectedIndex;
        }
    }

    
}
