using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_isp.Vehicles
{
    class Motorcycle : IVehicleMotorcycle
    {

        private string color;
        private int year;
        private double engine;
        private int seats;
        private int doors;

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }


        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            Console.WriteLine($"Criando uma moto {color}, ano {year}, motor {engine} cilindradas");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os Motores da Moto.");
        }
    }
}
