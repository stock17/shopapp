using shopapp.presenter;
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
    public partial class MainForm : Form, ShopAppPresenter.IMainForm
    {
        private ShopAppPresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new ShopAppPresenter(this);
            presenter.onStart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            EditCustomerForm editCustomerForm = new EditCustomerForm();
            if (editCustomerForm.ShowDialog(this) == DialogResult.OK)
            {
                System.Console.WriteLine("OK");
            }
            else {
                System.Console.WriteLine("CANCEL");
            }
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void refreshInfo (List<Customer> list)
        {
            foreach (Customer c in list)
            {
                this.customersListBox.Items.Add(c);
            }

        }
    }
}
