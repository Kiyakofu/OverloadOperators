using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadOperators
{
    internal class Shop
    {
        public string Title { get; set; }
        public int Square { get; set; }

        public Shop(string title, int square) 
        {
            Title = title;
            Square = square;
        }

        public static Shop operator +(Shop shop, int value)
        {
            return new Shop(shop.Title, shop.Square + value);
        }
        public static Shop operator -(Shop shop, int value)
        {
            return new Shop(shop.Title, shop.Square - value);
        }
        public static bool operator ==(Shop s1, Shop s2)
        {
            return s1.Square == s2.Square;
        }
        public static bool operator !=(Shop s1, Shop s2)
        {
            return !(s1.Square == s2.Square);
        }
        public static bool operator >(Shop s1, Shop s2)
        {
            return s1.Square > s2.Square;
        }
        public static bool operator <(Shop s1, Shop s2)
        {
            return s1.Square < s2.Square;
        }
        public override string ToString()
        {
            return $"title: {Title}; Square: {Square}";
        }

    }
}
