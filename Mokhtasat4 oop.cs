using System;

namespace project

{
    class Distance
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;
        public int X1
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
            set { y2 = value; }
        }
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
    }

        class Project
        {
        public static void Main()
        {
          Console.WriteLine("x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("x3: ");
        int x3 = Convert.ToInt32(Console.ReadLine());
            
          Console.WriteLine("x4: ");
        int x4 = Convert.ToInt32(Console.ReadLine());
            
          Console.WriteLine("y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());
            
          Console.WriteLine("y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("y3: ");
        int y3 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("y4: ");
        int y4 = Convert.ToInt32(Console.ReadLine());
           
        Distance line1 = new Distance(x1, x2, y1, y2);
        Distance line2 = new Distance(x3, x4, y3, y4);
        if (line1.calc() > line2.calc())
        {
            Console.WriteLine("khat 1 bozorgtar az 2");
        }
        else if (line2.calc() < line1.calc())
        {
            Console.WriteLine("khat 2 kochiktar az 1");
        }
        else
        {
            Console.WriteLine("Error");

        }
        

        }
    }
}