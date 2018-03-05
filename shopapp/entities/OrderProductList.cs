using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.entities
{
    [DataContract]
    public class OrderProductList
    {
        private static int nextId;

        public static int NextId
        {
            set {   nextId = value;   }
            get {   return nextId;  }
        }

        [DataMember]
        public int Id { get; set; }
        
        public List<Product> ProductList { set; get; }
        [DataMember]
        public List<int> ProductIdList { set; get; }
        [DataMember]
        public List<int> QuantityList { set; get; }

        public OrderProductList (List<Product> productList, List<int> quantityList)
        {
            this.Id = nextId++;
            this.ProductList = productList;
            this.QuantityList = quantityList;
            this.ProductIdList = new List<int>();
            foreach (Product p in ProductList) {
                ProductIdList.Add(p.Id);
            }
           
        }
        
    }
}
