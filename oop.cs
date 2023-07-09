using System;
namespace Project{ class Mosalas{
        private double a,b,c,h;
        public double A{
            get { return a; }
            set{ if (a > 0){a = value;}}}
        public double B{
            get { return b; }
            set{ if (b>0){b= value;}}}
        public double C{
            get { return c; }
            set{ if (c>0){c= value;}}}
        public double H{
            get { return h; }
            set{ if (h> 0){h = value;}}}
        public Mosalas() { }
        public Mosalas(double A, double B, double C, double H){a = A;b = B;c = C;h = H;}
        public double Area1()
        {return (a * h) / 2;}
        public double Perimeter1()
        {return a + b + c;}}
    class Moraba{
        private double a;
        public double A{
            get { return a; }
            set{if (a > 0){a = value;}}}
        public Moraba() { }
        public Moraba(double A){a = A;}
        public double Area2(){return Math.Pow(a, 2);}
        public double Perimeter2(){return 4 * a;}}
    class Rectangle{
        private double a;
        private double b;
        public double A{
            get { return a; }
            set{if (a > 0){a = value;}}}
        public double B{
            get { return b; }
            set{if (b> 0){b = value;}}}
        public Rectangle() { }
        public Rectangle(double A, double B){a = A;b = B;}
        public double Area3(){return a * b;}
        public double Perimeter3() {return 2 * a + 2 * b;}}
    class Circle{
        private double r;
        double pi = 3.14;
        public double R
        {
            get { return r; }
            set
            {
                if (r > 0)
                {
                    r = value;
                }
            }
        }
        public Circle() { }
        public Circle(double R)
        {
            r = R;
        }
        public double Area4()
        {
            return pi * Math.Pow(r, 2);
        }
        public double Perimeter4()
        {
            return 2 * r * pi;
        }
    }
    class Trapezoid
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double h;
        public double A{
         get { return a; }
        set{if (a > 0){a = value;}}}
        public double B{
         get { return b; }
        set{if (b > 0){b = value;}}}
        public double C{
         get { return c; }
        set{if (c > 0){c = value;}}}
        public double D{
         get { return d; }
        set{if (d > 0){d = value;}}}
        public double H{
         get { return h; }
        set{if (h > 0){h = value;}}}
        public Trapezoid() { }
        public Trapezoid(double A, double B, double C, double D, double H){a = A;b = B; c = C;d = D;h = H;}
        public double Area5()
        {return ((a + b) / 2) * h;}
        public double Perimeter5()
        {return a + b + c + d;}}
    class Ellipse{
        private double a;
        private double b;
        double pi = 3.14;
        public double A
        {
            get { return a; }
            set
            {
                if (a < 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b < 0)
                {
                    b = value;
                }
            }
        }
        public Ellipse() { }
        public Ellipse(double A, double B)
        {
            a = A;
            b = B;
        }
        public double Area6()
        {
            return pi * a * b;
        }
        public double Perimeter6()
        {
            return (a + b) * pi;
        }
    }
    class Polygon
    {
        private double a;
        private double n;
        private double h;
        public double A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public double N
        {
            get { return n; }
            set
            {
                if (n > 0)
                {
                    n = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (h > 0)
                {
                    h = value;
                }
            }
        }
        public Polygon() { }
        public Polygon(double A, double N, double H)
        {a = A; n = N; h = H;}
        public double Area7()
        {return (n * a * h) / 2;}
        public double Perimeter7()
        {return a * n;}}class Test{
        public static void Main(){
                Console.WriteLine("shekl:");
                Console.WriteLine("1-Mosalas   2-Moraba  3-Mostatil  4-Dayere  5-Zozanaghe  6-Beizi  7-Chandzeli ");
                Console.Write("shekl: ");
                double choose = Convert.ToDouble(Console.ReadLine());
                if (choose == 1){
                Console.WriteLine("azla va ertefa E Mosalas:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("h = ");
                double h = Convert.ToDouble(Console.ReadLine());
                Mosalas T1 = new Mosalas(a, b, c, h);
                double A1 = T1.Area1();
                Console.Write("Masahat = ");
                Console.WriteLine(A1);
                double P1 = T1.Perimeter1();
                Console.Write("Mohit = ");
                Console.WriteLine(P1);
                }else if (choose == 2){
                Console.WriteLine("Azla moraba:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Moraba S1 = new Moraba(a);
                double A2 = S1.Area2();
                Console.Write("Masahat = ");
                Console.WriteLine(A2);
                double P2 = S1.Perimeter2();
                Console.Write("Mohit = ");
                Console.WriteLine(P2);}else if (choose == 3){
                Console.WriteLine("Azla mosalas:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Rectangle R1 = new Rectangle(a, b);
                double A3 = R1.Area3();
                Console.Write("Masahat = ");
                Console.WriteLine(A3);
                double P3 = R1.Perimeter3();
                Console.Write("Mohit = ");
                Console.WriteLine(P3);}else if (choose == 4){
                Console.WriteLine("shoa dayere:");
                Console.Write("r = ");
                double r = Convert.ToDouble(Console.ReadLine());
                Circle C1 = new Circle(r);
                double A4 = C1.Area4();
                Console.Write("Masahat = ");
                Console.WriteLine(A4);
                double P4 = C1.Perimeter4();
                Console.Write("Mohit = ");
                Console.WriteLine(P4);
                }else if (choose == 5){
                Console.WriteLine("Azla va Ertefa Zozanaghe:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("d = ");
                double d = Convert.ToDouble(Console.ReadLine());
                Console.Write("h = ");
                double h = Convert.ToDouble(Console.ReadLine());
                Trapezoid TR1 = new Trapezoid(a, b, c, d, h);
                double A5 = TR1.Area5();
                Console.Write("Masahat = ");
                Console.WriteLine(A5);
                double P5 = TR1.Perimeter5();
                Console.Write("Mohit = ");
                Console.WriteLine(P5);
                }else if (choose == 6){
                Console.WriteLine("Shoa Beyzi:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Ellipse E1 = new Ellipse(a, b);
                double A6 = E1.Area6();
                Console.Write("Masahat = ");
                Console.WriteLine(A6);
                double P6 = E1.Perimeter6();
                Console.Write("Mohit = ");
                Console.WriteLine(P6);
                }else if (choose == 7){
                Console.WriteLine("tedad Azla ChandZeli:");
                Console.Write("n = ");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Zele ChandZeli va ertefa ChandZeli:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("h = ");
                double h = Convert.ToDouble(Console.ReadLine());
                Polygon PL1 = new Polygon(a, n, h);
                double A7 = PL1.Area7();
                Console.Write("Masahat = ");
                Console.WriteLine(A7);
                double P7 = PL1.Perimeter7();
                Console.Write("Mohit = ");
                Console.WriteLine(P7);
                }else{Console.WriteLine("shekl ra dorost entekhab konid");} }}}


