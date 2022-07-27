using System;

namespace multilevel_inheritance
{
     class car
    {
        public string model;
        public int price;
        public string color;

        public void printcarinfo()
        {
            Console.WriteLine("model="+model);
            Console.WriteLine("price="+price);
            Console.WriteLine("color="+color);
        }
    }

    class farrari : car
    {
        public int speed;

        public void printspeed()
        {
            Console.WriteLine("speed="+speed);
        }
    }

    class maruti : farrari
    {
        public int mileage;
        public void printmileage()
        {
            Console.WriteLine("mileage=" + mileage);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            maruti obj = new maruti();
            obj.model = "BMw";
            obj.price = 20000;
            obj.color = "black";
            obj.speed = 100;
            obj.mileage = 22;
            obj.printcarinfo();
            obj.printspeed();
            obj.printspeed();
            Console.ReadLine();
        }
    }
}
