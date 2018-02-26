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

        public ShopAppModel(){
            
            // fake read from file
            customerList = new List<Customer>();
            customerList.Add(new Customer(0, "John Connor", true, 14, 3));
            customerList.Add(new Customer(1, "Sarah Connor", false, 36, 2));
            customerList.Add(new Customer(2, "T-800", true, 100, 0));
        }


        public List<Customer> getCustomerList()
        {
            return customerList;
        }


        public void addCustomer(Customer c) {
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


    }
}
