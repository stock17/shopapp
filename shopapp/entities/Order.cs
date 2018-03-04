using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.entities
{
    class Order
    {
        private int nextId;
        public int NextId
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

        public int Id { get; }
        public int CustomerId { set; get; }
        public int ProductListId { set; get; }
        public DateTime Date { set; get; }
    }
}
