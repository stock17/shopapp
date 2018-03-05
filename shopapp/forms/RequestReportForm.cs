﻿using shopapp.entities;
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
    public partial class RequestReportForm : Form
    {
        ShopAppPresenter Presenter;
        List<Product> ProductList;
        List<Customer> CustomerList;


        public RequestReportForm(List<Customer> customerList, List<Product> productList)
        {
            InitializeComponent();
            this.ProductList = productList;
            this.CustomerList = customerList;            
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.customerCheckedListBox.DataSource = CustomerList.Select(c => c.Name).ToList();
            this.statusCheckedListBox.DataSource = Enum.GetValues(typeof(Customer.SocialStatus));
            for (int i = 0; i < this.statusCheckedListBox.Items.Count; i++)
                statusCheckedListBox.SetItemChecked(i, true);
            this.productCheckedListBox.DataSource = ProductList.Select(p => p.Name).ToList();
        }

        public List<Customer> ReportCustomerList 
        {
            get { 
                List<Customer> list = new List<Customer>();
                for (int i = 0; i < this.customerCheckedListBox.Items.Count; i++)
                {
                    if (customerCheckedListBox.GetItemChecked(i))
                    {
                        list.Add(CustomerList[i]);
                    }
                }
                return list;
            }
        }

        public List<Product> ReportProductList
        {
            get
            {
                List<Product> list = new List<Product>();
                for (int i = 0; i < this.productCheckedListBox.Items.Count; i++)
                {
                    if (productCheckedListBox.GetItemChecked(i))
                        list.Add(ProductList[i]);
                }
                return list;
            }
        }

        public int FromAge {
            get
            {
                string text = this.fromAgeTextBox.Text;
                if (text == "")
                    return Customer.MIN_AGE;
                else
                    return Int32.Parse(text);
            }
        }

        public int ToAge
        {
            get
            {
                string text = this.toAgeTextBox.Text;
                if (text == "")
                    return Customer.MAX_AGE;
                else
                    return Int32.Parse(text);
            }
        }

        // DONE STATUS
        public List<bool> StatusList
        {
            get
            {
                List<bool> list = new List<bool>();
                for (int i = 0; i < statusCheckedListBox.Items.Count; i++)
                    list.Add(statusCheckedListBox.GetItemChecked(i));
                return List;
            }           

        }
               
        public DateTime FromDate
        {
            get
            {
                if (this.dateCheckBox.Enabled)
                    return DateTime.MinValue;
                else
                    return dateFromTimePicker.Value;
            }
        }

        public DateTime ToDate
        {
            get
            {
                if (this.dateCheckBox.Enabled)
                    return DateTime.MaxValue;
                else
                    return dateToTimePicker.Value;
            }
        }


        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            this.dateFromTimePicker.Enabled = !box.Checked;
            this.dateToTimePicker.Enabled = !box.Checked;
        }
    }
}
