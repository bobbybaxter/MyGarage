using MyGarage.Garage;
using MyGarage.Vehicles;
using System;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new HondaAccord();
            myCar.ListFeatures();
            myCar.Refuel();
            myCar.Drive();
            myCar.Brake();

            var myAircraft = new Aircraft();
            myAircraft.Refuel();
            myAircraft.Fly();
            myAircraft.Brake();

            var myWatercraft = new Watercraft();
            myWatercraft.Refuel();
            myWatercraft.Drive();
            myWatercraft.Brake();
        }
    }
}
