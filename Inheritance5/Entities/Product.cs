﻿using System.Globalization;
namespace Inheritance5.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return $"{Name}, ${Price:F2, CultureInfo.InvariantCulture}";
        }
    }
}
