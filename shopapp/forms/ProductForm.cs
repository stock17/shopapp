using shopapp.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopapp
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();            
            this.ProductId = Product.NextId;
        }

        public ProductForm(Product product) : this()
        {
            LoadProduct(product);
        }

        private void LoadProduct(Product product)
        {
            this.ProductId = product.Id;
            this.ProdName = product.Name;
            this.ProductPrice = product.Price;
            this.ProductQuantity = product.Quantity;
        }

        public int ProductId
        {
            get { return Int32.Parse(this.idtextBox.Text); }
            set { this.idtextBox.Text = value.ToString(); }
        }

        public string ProdName
        {
            get { return this.nameTextBox.Text; }
            set { this.nameTextBox.Text = value.ToString(); }
        }

        private decimal price;
        public decimal ProductPrice       
        {
            get {
                string text = Regex.Replace(this.priceTextBox.Text, @"[.,]", "");
                return Decimal.Parse(text);
            }
            set {
                this.price = value;
                this.priceTextBox.Text = (price / 100).ToString();
            }
        }

        
        public int ProductQuantity
        {
            get { return Int32.Parse(this.quantityTextBox.Text); }
            set { this.quantityTextBox.Text = value.ToString(); }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // check input info
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Input your name");
                DialogResult = DialogResult.None;
                return;
            }

            string age = ageTextBox.Text;
            if (ageTextBox.Text == "" || Int32.Parse(age) < 0 || Int32.Parse(age) > 120) {
                MessageBox.Show("Incorrect age");
                DialogResult = DialogResult.None;
                return;
            }
        }

        // check name input
        void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ('-'));
        }

        void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        
    }
}
