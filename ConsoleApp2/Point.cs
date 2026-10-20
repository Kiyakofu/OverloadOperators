using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadOperators
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static Point operator++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator--(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }

    }
    internal class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector() { }
        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X - v2.X, Y = v1.Y - v2.Y };
        }
        public static Vector operator *(Vector v1, int n)
        {
            v1.X *= n;
            v1.Y *= n;
            return v1;
        }
        public override string ToString()
        {
            return $"Vector: X = {X}, Y = {Y}";
        }
    }
}
