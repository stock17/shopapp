using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.entities
{
    [DataContract]
    class Product
    {
        public static int NextId;

        public Product(string name, decimal price, int quantity) {
            this.Id = NextId++;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        [DataMember]
        int Id { get; set; }
        [DataMember]
        string Name { get; set; }
        [DataMember]
        decimal Price { get; set; }
        [DataMember]
        int Quantity { get; set; }

    }
}
