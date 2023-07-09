using System;

namespace App
{
    class Project
    {
        public const int a= 3;
        static void Main()
        {
            int[,] arr = new int[a,a];
            int dupCount = 0;
            int dupNumber = 0;
            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y <a; y++)
                {
                    Console.WriteLine("Enter ["+ x+ "]["+ y+ "]: ");
                    arr[x,y] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter duplicate number : ");
            dupNumber = Convert.ToInt32(Console.ReadLine());

            for (int x = 0;x <a; x++)
            {
                for (int y=0 ; y<a ; y++)
                {
                    if (arr[y, x] == dupNumber)
                        ++dupCount;
                }
            }
            Console.WriteLine("Duplicate count for "+ dupNumber + "is : "+ dupCount);
        }

    }
}
