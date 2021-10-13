using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_isp.Vehicles
{
    interface IVehicleMotorcycle : IVehicle
    {
        void ConfigureMotorcycle(string color, int year, double engine);
    }
}
