using System;
namespace  project
{
    public class Teacher{
        private string id;
        private string name;
        private int hours;
        private int paperonehour;
        public string Id{
        get {return id;}
        set{id = value;}
        }
        public string Name{
        get {return name;}
        set{name = value;}
        }
        public int Hours{
        get {return hours;}
        set{hours = value;}
        }
        public int Paperonehour{
        get {return paperonehour;}
        set{ if(value>0){
            paperonehour = value;}
        }
    
        }
        class Teacher(){}
        class Teacher(string Id,string Name,int Hours,int Paperonehour){
              id = Id;
              name = Name;
              hours = Hours;
              paperonehour = Paperonehour;

        }
        public long payment(){
           return hours * paperonehour;
        }
       class test{
        public static void Main(){
            Console.WriteLine("id: ");
          int id = Convert.ToString(Console.ReadLine());
          Teacher t1 = new Teacher(id);
          int s1 = t1.Teacher();
          Console.WriteLine("Hagh Ol Tadris: "+s1);
        }
       }
    }
}