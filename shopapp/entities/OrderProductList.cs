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
        [DataMember]
        public Dictionary<int, int> productListDictionary { set; get; }

        public OrderProductList (Dictionary<int, int> productList)
        {
            this.Id = nextId++;
            this.productListDictionary = productList;
        }
        
    }
}
