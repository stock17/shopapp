using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.entities
{
    [DataContract]
    public class Order
    {
        private static int nextId;
        public static int NextId
        {
            get { return nextId; }
            set { nextId = value; }
        }

        public Order(Customer customer, OrderProductList productList, DateTime date)
        {
            this.Id = nextId++;
            this.OrderCustomer = customer;
            this.CustomerId = customer.Id;
            this.ProductList = productList;
            this.ProductListId = productList.Id;
            this.Date = date;
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int CustomerId { set; get; }
        [DataMember]
        public int ProductListId { set; get; }
        [DataMember]
        public DateTime Date { set; get; }

        public Customer OrderCustomer { set; get; }
        public OrderProductList ProductList { set; get; }
    }
}
