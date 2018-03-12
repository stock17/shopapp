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

namespace shopapp
{
    public partial class EditCustomerForm : Form, ILanguageChangeable
    {
        public EditCustomerForm()
        {
            InitializeComponent();
            statusComboBox.DataSource = Enum.GetValues(typeof(Customer.SocialStatus));
            this.CustomerId = Customer.NextId;
        }

        public EditCustomerForm(Customer customer) : this()
        {
            LoadCustomer(customer);
        }

        private void LoadCustomer(Customer customer)
        {
            this.CustomerId = customer.Id;
            this.CustomerName = customer.Name;
            this.CustomerSex = customer.Sex;
            this.CustomerAge = customer.Age;
            this.CustomerStatus = customer.Status;

        }

        public int CustomerId
        {
            get { return Int32.Parse(this.idtextBox.Text); }
            set { this.idtextBox.Text = value.ToString(); }
        }

        public string CustomerName
        {
            get { return this.nameTextBox.Text; }
            set { this.nameTextBox.Text = value.ToString(); }
        }

        public bool CustomerSex
        {
            get { return this.sexCheckBox.Checked; }
            set { this.sexCheckBox.Checked = value; }
        }

        public int CustomerAge
        {
            get { return Int32.Parse(this.ageTextBox.Text); }
            set { this.ageTextBox.Text = value.ToString(); }
        }

        public int CustomerStatus
        {
            get { return statusComboBox.SelectedIndex; }// Int32.Parse(this.statusComboBox.Text); }
            set { this.statusComboBox.SelectedIndex = value; }
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
            if (ageTextBox.Text == "" || Int32.Parse(age) < Customer.MIN_AGE || Int32.Parse(age) > Customer.MAX_AGE) {
                MessageBox.Show("Incorrect age");
                DialogResult = DialogResult.None;
                return;
            }
        }

        // check name input
        void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ' || e.KeyChar == ('-'));
        }

        void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public override string ToString()
        {
            return Name;
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            ChangeFormLanguage(LanguageSettings.CurrentLanguage);
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
    }
}
