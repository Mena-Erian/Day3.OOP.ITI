using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Point2D
    {
        public int X, Y;
        public Point2D(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                throw new ArgumentException("0 Or Less is Not Valid");
            }
            X = x; Y = y;
        }
    }
}
