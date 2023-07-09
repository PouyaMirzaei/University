using System;
namespace test{
    class test1{
        public static void Main(){
        int[] array = new int[10];
        for(int i=0 ; i< 10 ; i++ ){
            Console.WriteLine("Element {0} = ");
            array[i] = Convert.ToInt32(Console.ReadLine());

        }
        Calc (array);
        }
        private static void Calc(int [] array){
         for(int i=1 ; i <= 8 ; i++){
           array[i] = (array[i-1] + array[i] + array[i+1])/3;

         }
         for(int i=0 ; i<=9 ; i++){
            Console.WriteLine("Result= "+ array[i]);
         }

        }
    }
}