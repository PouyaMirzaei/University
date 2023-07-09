//Mohit o Masahat Dayere


using System;
namespace Project{
    class Circle
    {
        private int r;
        int Pi =3;
        public int R{
          get {return R;}

            set{ if (value > 0)
                {
               r = value;
                }
            
            }
        }
        public Circle(){}
            public Circle(int R){
              r = R; }
        public int s()
         { return r*r*Pi;}
        public int A(){
            return 2*r*Pi;
        }
    }
    class Test{
        public static void Main(){
             Console.WriteLine("r: ");
            int r = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("----");

             Circle c1 = new Circle(r);

            int s1 = c1.s();
             Console.WriteLine("masahat: "+s1);

             Console.WriteLine("----");

            int A1 = c1.A();
             Console.WriteLine("mohit: "+A1);

             Console.WriteLine("----");}}}
