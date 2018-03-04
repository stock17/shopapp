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
        public AddProductForm(string productName)
        {
            InitializeComponent();
            this.productNameAddProductFormTextBox.Text = productName;
        }

        public int Quantity
        {
            get { return Int32.Parse(quantityTextBox.Text); }
        }
    }
}
