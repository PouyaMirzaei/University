using System;
namespace Project{
    class test1{
        public static void Main(){
             Console.WriteLine("Enter X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x%2==0){
                even(x);
            }else{
                odd(x);            }        }
        private static void  even(int x){
            int sum = 0,zarb = 1;
            for(int i=2 ; i<=x ; i++){
                sum +=i;
                zarb *= i;
                Console.WriteLine("majmoe: "+ "\n"+sum);
                Console.WriteLine("haselzarb: "+ "\n"+zarb);
                Console.WriteLine("---------------");}}
        private static void odd(int x){
            int sum = 0,zarb = 1;
            for(int i=1 ; i<=x ; i++){
                sum +=i;
                zarb *= i;
                Console.WriteLine("majmoe: "+sum);
                Console.WriteLine("haselzarb: "+zarb);                
            }
        }
    }
}
