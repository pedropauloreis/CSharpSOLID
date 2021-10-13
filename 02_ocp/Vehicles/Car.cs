using System;


namespace _02_ocp.Vehicles
{
    class Car : Vehicle
    {
        private int seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors) : base (color, year, engine)
        {
            this.seats = seats;
            this.doors = doors;
            ConfigureCar();
        }

        private void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {this.color}, ano {this.year}, motor {this.engine}, {this.seats} assentos e {this.doors} portas");
            StartVehicle();
        }

    }
}
