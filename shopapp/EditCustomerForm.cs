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


        public int CustomerId
        {
            get { return Int32.Parse(this.idtextBox.Text); }
        }

        public string CustomerName
        {
            get { return this.nameTextBox.Text; }
        }

        public bool CustomerSex
        {
            get { return this.sexCheckBox.Checked; }
        }

        public int CustomerAge
        {
            get { return Int32.Parse(this.ageTextBox.Text); }
        }

        public int CustomerStatus
        {
            get { return Int32.Parse(this.statusTextBox.Text); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // TODO check input info
            
        }
    }
}
