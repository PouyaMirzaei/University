using System;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three sides of a triangle:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine()); 
            Calc(a,b,c);
        }
        private static void Calc(int a , int b ,int c)
        {
        if (a+ b > c &&  a + c > b &&  b + c > a)
           Console.WriteLine("This is a triangle.");
           Console.WriteLine("-------------------------");

           {
           if (a==b && b==c)
                {
                    Console.WriteLine("The triangle is equilateral (motasavi ol azla).");
                    Console.WriteLine("-------------------------");
                }
                else if (a == b  || a == c || b == c)
                {
                    Console.WriteLine("The triangle is isosceles (motasavi ol saghain).");
                    Console.WriteLine("-------------------------");

                }
                else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                         Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                         Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("The triangle is right-angled (ghaem ol zavie).");
                    Console.WriteLine("-------------------------");

                }
                else if(a != b && a!=c && b!=c){
                Console.WriteLine("mokhtalef ol azla");
                }
                else
                {
                Console.WriteLine("Not a triangle!");
                Console.WriteLine("-------------------------");

                }
            }
        }
    }
}
   

           



