namespace CodeCampSDQ.Common
{
    public class Point
    {
        public int Id { get; set; }

        public Point()
        {
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }
}