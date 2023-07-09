using System;
namespace test{
    class program{

    
    public static void Main(){
         Console.WriteLine("Enter x: ");
    double x = Convert.ToInt32(Console.ReadLine());
    

    Calc(x);
         
    }
    private static void Calc(double x ){
        double y = Math.Sqrt(Math.Abs(x)+Math.Sqrt(Math.Abs(x)+Math.Sqrt(Math.Abs(x))));
      Console.WriteLine("Resault = " + y);
    }
 }
}