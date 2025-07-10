namespace Assignment
{
    internal class Program
    {
        static void Main( )
        {
            #region Lab1
            //Point2D p1 = new Point2D(3, 4);
            //Point2D p2 = new Point2D(7, 1);

            //Line line1 = new Line(p1, p2);

            //Console.WriteLine(line1.GetLength()); 
            #endregion

            #region Lab2
            Point2D p1 = new Point2D(4, 3);
            Point2D p2 = new Point2D(7, 8);

            Rectangle rectangle1 = new Rectangle(p1, p2);

            Console.WriteLine(rectangle1.CalculateArea());

            Square sqr1 = new Square(5);
            Console.WriteLine(sqr1.CalculateArea());
            #endregion


        }
    }
}
