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
    public partial class AddProductForm : Form, ILanguageChangeable
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

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            ChangeFormLanguage(LanguageSettings.CurrentLanguage);
        }
    }
}
