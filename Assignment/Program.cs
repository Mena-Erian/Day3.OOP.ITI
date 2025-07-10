namespace Assignment
{
    internal class Program
    {
        static void Main( )
        {
            Point2D p1 = new Point2D(3, 4);
            Point2D p2 = new Point2D(7, 1);

            Line line1 = new Line(p1, p2);

            Console.WriteLine(line1.GetLength());
        }
    }
}
