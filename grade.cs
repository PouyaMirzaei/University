using System;
namespace Project{
    class test1{
        public static void Main(){

            Console.WriteLine("Enter a: ");
             double a  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b: ");
             double b  = Convert.ToDouble(Console.ReadLine());
             
            double  Result = Calc(a,b);
            if (Result >= 10){
                Console.WriteLine("Pass");
            }else{
                Console.WriteLine("Failed");
            }
        }
        private static double Calc(double a,double b){
          double Result = (a*0.35)+(b*0.65);
          return Result;
        
        }
    }
}