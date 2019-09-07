using MyGarage.Vehicles;
using System;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            // myCar.Refuel();
            myCar.Drive();
            myCar.Brake();
        }
    }
}
