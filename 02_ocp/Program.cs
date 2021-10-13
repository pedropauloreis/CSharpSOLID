using _02_ocp.Vehicles;
using System;


namespace _02_ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if(type == TypeVehicle.CAR)
            {
                Car vehicle = new Car("Azul", 2022, 2.0, 5, 4);

            }
            else
            {
                Motorcycle vehicle = new Motorcycle("Branco", 2021, 250);
            }

            Console.ReadLine();
        }
    }
}
