﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.entities
{
    [DataContract]
    public class Product
    {
        public static int NextId;

        public Product(string name, decimal price, int quantity) {
            this.Id = NextId++;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public int Quantity { get; set; }

    }
}
