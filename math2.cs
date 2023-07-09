using System;
using System.Runtime.InteropServices;
namespace test
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Calc(x);
        } 
        private static void  Calc(int x)
        {
          double Result = Math.Pow(x,2)+(2*x)-4;
          Console.WriteLine("Result: "+Result);   }   }  }  