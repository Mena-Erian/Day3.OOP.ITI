using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Line
    {
        Point2D Point1;
        Point2D Point2;

        public Line(Point2D point1, Point2D point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public int GetLength()
        {
            double length = Math.Sqrt(Math.Pow((Point2.X - Point1.X), 2) + Math.Pow((Point2.Y - Point1.Y), 2));

            return (int)Math.Round(length);
        }
    }
}
