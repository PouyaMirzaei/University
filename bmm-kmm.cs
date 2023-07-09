using System;
namespace ConsoleApplication{
    class Program{
        static void Main(string[] args){
            Console.Write("Please Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("K.M.M={0}\nB.M.M ={1}",kmm(num1,num2),Bmm(num1, num2));}
        public static int kmm(int a, int b){
            int max = 0;
            if (a > b) max = a;
            else max = b;
            while (true){
                if (max % a == 0 && max % b == 0) break;
                else ++max;}
                return max;}
        public static int Bmm(int a, int b){
            while (a != b)
            {
                if (a > b)
                a -= b;
                else
                b -= a;}
                return a;}}}
