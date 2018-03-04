using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.entities
{
    class OrderProductList
    {
        private static int nextId;

        public static int NextId
        {
            set {   nextId = value;   }
            get {   return nextId++;  }
        }

        public int Id { get; }
        public Dictionary<int, int> productListDictionary { set; get; }

        public OrderProductList (Dictionary<int, int> productList)
        {
            this.Id = NextId;
            this.productListDictionary = productList;
        }
        
    }
}
