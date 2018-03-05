using shopapp.entities;
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

namespace shopapp.forms
{
    public partial class ReportForm : Form
    {
        ShopAppPresenter Presenter;
        List<Product> ProductList;
        List<Customer> CustomerList;

        public ReportForm(List<Customer> customerList, List<Product> productList)
        {
            InitializeComponent();
            this.ProductList = productList;
            this.CustomerList = customerList;            
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.customerCheckedListBox.DataSource = CustomerList.Select(c => c.Name).ToList();


        }
    }
}
