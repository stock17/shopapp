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
    public partial class AddProductForm : Form
    {
        public AddProductForm(Product product)
        {
            InitializeComponent();
            this.productNameTextBox.Text = product.Name;
            this.productPriceTextBox.Text = (product.Price / 100).ToString();
        }

        public int Quantity
        {
            get { return Int32.Parse(quantityTextBox.Text); }
        }
    }
}
