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
            int n = 0;

            foreach (Order o in list)
            {                
                ListViewItem lvi = new ListViewItem((++n).ToString());                
                lvi.SubItems.Add(o.Date.ToString());
                lvi.SubItems.Add(o.OrderCustomer.Name.ToString());
                string text = "";
                for (int i = 0; i < o.ProductList.ProductList.Count; i++)
                {
                    text += o.ProductList.ProductList[i].Name + " - ";
                    text += o.ProductList.QuantityList[i] + " pc ";
                }
                lvi.SubItems.Add(text);

                reportListView.Items.Add(lvi);
                
            }

            reportListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //yourListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
