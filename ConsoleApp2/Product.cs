using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadOperators
{
    internal class Product
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public Product(string title, int count, int price)
        {
            Title = title;
            Count = count;
            Price = price;
        }
        public static Shop operator +(Product product, int value)
        {
            return new Shop(product.Title, product.Count + value);
        }
        public static Shop operator -(Product product, int value)
        {
            return new Shop(product.Title, product.Count - value);
        }
    }
}
