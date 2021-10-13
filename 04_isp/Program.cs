using System;
using _04_isp.Vehicles;

namespace _04_isp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Azul", 2021, 4.0, 2, 2);
            Motorcycle motorcycle = new Motorcycle("Branco", 2020, 250);
            Console.ReadKey();
        }
    }
}
