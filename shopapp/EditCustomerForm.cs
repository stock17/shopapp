using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopapp
{
    public partial class EditCustomerForm : Form
    {
        public EditCustomerForm()
        {
            InitializeComponent();
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
            get { return Int32.Parse(this.statusTextBox.Text); }
            set { this.statusTextBox.Text = value.ToString(); }
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
