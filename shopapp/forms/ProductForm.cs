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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopapp
{
    public partial class ProductForm : Form, ILanguageChangeable
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
                //string text = Regex.Replace(this.priceTextBox.Text, @"[.,]", "");
                string text = this.priceTextBox.Text;
                double dPrice = double.Parse(text, CultureInfo.InvariantCulture);
                return (Decimal) (dPrice  * 100);
            }
            set {
                this.price = value;
                this.priceTextBox.Text = (price / 100).ToString();
            }
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
           

            string price = priceTextBox.Text;
            bool PriceOK = Regex.IsMatch(price, "^\\d+(.\\d{1,2})?$");
            if (!PriceOK) {
                MessageBox.Show("Incorrect price");
                DialogResult = DialogResult.None;
                return;
            }
            
        }

        // check name input
        void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ('-')
                || char.IsDigit(e.KeyChar) || e.KeyChar == (' '));
        }

        //check quantity input
        void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back );
        }


        //check price input
        void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.');
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

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ChangeFormLanguage(LanguageSettings.CurrentLanguage);   
        }
    }
}
