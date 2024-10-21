using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Pro
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int car;

            Car car1 = new Car("Honda s2000", 2002, 225, 60, 14);
            Car car2 = new Car("Corvette", 2003, 345, 80, 23);

            car2.Info();
            car1.Info();

            Console.WriteLine("Choose a car by entering its number");
            Console.WriteLine("In stock we have " + "1."+car1.name + "- 2."+car2.name);
            car = Convert.ToInt32(Console.ReadLine());

            if (car == 1)
            {
                car1.Run();
            }
            else if (car == 2)
            {
                car2.Run();
            }
        }
    }
}