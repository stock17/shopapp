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
        List<Order> currentOrderList;

        public ResultReportForm(List<Order> list)
        {
            InitializeComponent();
            currentOrderList = list;
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();            
            saveFileDialog1.Title = "Save to File";
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
            string text = GetTextForFile();

            if (fileName != "")
            {
                System.IO.File.WriteAllText(fileName, text);;
            }
        }

        private string GetTextForFile()
        {
            string result = "";
            foreach (Order o in currentOrderList)
            {
                string line = o.Date.ToString() + " : ";
                line += o.OrderCustomer.Name.ToString() + " : ";                
                for (int i = 0; i < o.ProductList.ProductList.Count; i++)
                {
                    line += o.ProductList.ProductList[i].Name + " - ";
                    line += o.ProductList.QuantityList[i] + " pc ";
                }
                line += System.Environment.NewLine;
                result += line;
            }

            return result;
        }
    }
    
}
