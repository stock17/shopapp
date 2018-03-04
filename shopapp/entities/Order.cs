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
            get { return nextId++; }
            set { nextId = value; }
        }

        public Order(int customerId, int productListId, DateTime date)
        {
            this.Id = NextId;
            this.CustomerId = customerId;
            this.ProductListId = productListId;
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
    }
}
