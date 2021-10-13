using System;


namespace _02_ocp.Vehicles
{
    class Motorcycle : Vehicle
    {


        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureCar();
        }

        private void ConfigureCar()
        {
            Console.WriteLine($"Criando uma moto {color}, ano {year}, motor {engine} cilindradas");
            StartVehicle();
        }
    }
}
