using System;

namespace App
{
    class Project
    {
        public static int size = 4; 
        static void Main()
        {
            double[,] matrix = new double[size,size];

            matrix = fillMatrix(matrix);
            matrix = filterMatrix(matrix);
            pMatrix(matrix);
        }

        private static void pMatrix(double[,] matrix)
        {
            for (int a = 0; a < size; a++)
            {
                for (int b = 0; b < size; b++)
                {
                    Console.Write(matrix[a,b] + " ");
                }

            }
        }

        private static double[,] fillMatrix(double[,] matrix)
        {

            for (int a = 0; a < size; a++)
            {
                for (int b = 0; b < size; b++)
                {
                    Console.WriteLine("enter [" + a + "]["+ b +"] , element: ");

                    matrix[a,b] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        private static double[,] filterMatrix(double[,] matrix)
        {
            double tempAvg = 0;
            for (int a = 1; a < size - 1; a ++)
            {
                for (int b = 1; b < size - 1; b++)
                {

                   
                    for (int r = a - 1; r <= a + 1; r++)
                    {
                        for(int z = b - 1;z <= b + 1; z++)
                        {
                            Console.Write(matrix[r,z] + "-");
                         
                            tempAvg += matrix[r,z];
                        }
                    }
                    Console.WriteLine("sum:" + tempAvg);
                    matrix[a,b] = tempAvg / 9;

                    tempAvg = 0;
                }
            }

            return matrix;
        }

    }
}