using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle
    {
        Point2D P1, P2;
        protected double Length;
        protected double Width;
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public Rectangle(Point2D p1, Point2D p2)
        {
            P1 = p1;
            P2 = p2;
            Length = P2.X - P1.X;
            Width = P2.Y - P1.Y;
        }
        public int CalculateArea()
        {
            return (int)Math.Round(Length * Width);
        }


    }
}
