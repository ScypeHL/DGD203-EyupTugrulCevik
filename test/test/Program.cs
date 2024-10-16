using System;
using System.Runtime.ConstrainedExecution;

namespace Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Honda s2000", 2002, 225, 60, 14);
            Car car2 = new Car("Corvette", 2003, 345, 80, 23);

            car1.Info();
            car2.Info();
        }
    }
}