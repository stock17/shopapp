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
    public partial class ResultReportForm : Form
    {
        public ResultReportForm(List<Order> list)
        {
            InitializeComponent();
            LoadOrderList(list);
        }

        public void LoadOrderList(List<Order> list)
        {
            foreach (Order o in list)
            {
                orderListBox.Items.Add(o.Date + " " + o.OrderCustomer.Name);
            }
        }
    }
}
