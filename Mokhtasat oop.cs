using System;

namespace project{
    class Distance{
        private int x1;
        private int x2;
        private int y1;
        private int y2;
        public  int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int X2
        {
            get { return x2; }

            set { x2 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int Y2
        {
            get { return y2; }
            set { y2 = value; }}
        public Distance() { }
        public Distance(int x1, int x2, int y1, int y2)
        {
            x1 = X1;
            x2 = X2;
            y1 = Y1;
            y2 = Y2;
        }
        public double calc()
        {
            double res = Math.Sqrt(
                Math.Pow((x2 - x1), 2) +
                Math.Pow((y2 - y1), 2));
            return res;
        }
        class test{
            public static void Main(){
                Distance Dis  = new Distance(0,1,0,1);
                 Console.WriteLine(Dis.calc());

            }
        }
    }
}





//Way 2: 

/*

using System;
namespace Distance
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public double DistanceTo(Point other)
        {
            int dx = X - other.X;
            int dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            double distance = p1.DistanceTo(p2);

            Console.WriteLine($"Fasele beineshon ({x1}, {y1}) va ({x2}, {y2}) hast:  {distance:F2}");
        }
    }
}

*/