using System;
namespace Project
{
    class Hoghogh{
    private double khales;
    private double bimeh;
    private double maliat;
    
    public double Khales{
        get {return khales;}
        set{khales = value;}
    }

    public double Bimeh{
        get {return bimeh;}
        set{bimeh = value;}
    }

    public double Maliat{
        get {return maliat;}
        set{maliat = value;}
    }
    
    public Hoghogh(){}
    public Hoghogh(double khales , double Bimeh , double maliat){
        khales = Khales;
        bimeh = Bimeh;
        maliat = Maliat;
    }
    public double Calc(){
        return (khales  - bimeh )/ maliat;
        
    }
}
    class Projects{
        public static void Main(){
              Console.WriteLine("khales: ");
            double khales = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("bime: ");
            double bimeh = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("maliat: ");
            double maliat = Convert.ToDouble(Console.ReadLine());

            Hoghogh pool = new Hoghogh(khales,bimeh,maliat);

                 double P = pool.Calc();
                 Console.WriteLine("p: "+P);
            }
        }
    }
