using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.model
{
    class ShopAppModel
    {
        private List<Customer> customerList;
        private FileHelper fileHelper;

        public ShopAppModel()
        {
           fileHelper = FileHelper.GetInstance();
           customerList = fileHelper.LoadCustomerFromFile();
        }


        public List<Customer> getCustomerList()
        {            
            return customerList;
        }


        public void addCustomer(Customer c)
        {
            customerList.Add(c);            
        }

        public void EditCustomer(Customer customer, int index)
        {
            customerList[index] = customer;            
        }

        public void RemoveCustomer(int index)
        {
            customerList.RemoveAt(index);            
        }

        public void SaveData() {
            fileHelper.SaveCustomerToFile(customerList);
        }

    }
}
