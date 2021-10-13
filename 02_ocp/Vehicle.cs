using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ocp
{
    class Vehicle
    {
        private string color;
        private int year;
        private double engine;
        private int seats;
        private int doors;

        public Vehicle(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;
        }

        public void Car()
        {
            Console.WriteLine($"Criando um carro {color}, ano {year}, motor {engine}, {seats} assentos e {doors} portas");
            StartVehicle();
        }


        public void Motorcycle()
        {
            Console.WriteLine($"Criando um carro {color}, ano {year}, motor {engine} cilindradas");
            StartVehicle();
        }


        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores");
        }

    }
}
