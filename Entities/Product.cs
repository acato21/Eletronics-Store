﻿using System.Text;
using System.Globalization;

namespace EletronicsStore.Entities
{
    class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public Product() 
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
