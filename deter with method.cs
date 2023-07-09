using System;

namespace Project{
class Program
{
    public static void  Main()
    {
        int []a = new int[5];
        for (int i=0 ; i<5 ; i++){
            Console.WriteLine("element {0} = ", i+1);
            a[i] = Convert.ToInt32(Console.ReadLine());

        }
        Calc(a);
    }
    private static void Calc(int [] a){
        for(int i=1 ; i<=3 ; i++){
            a[i] = (a[i-1] + a[i] + a[i+1])/3; 
        }
        for(int  i=0 ; i<=4 ; i++){
           Console.WriteLine("new element {0} = {1} ",i+1,a[i]);
        }
    }
}
}

