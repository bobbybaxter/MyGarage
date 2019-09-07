using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    class Vehicle
    {
        public int Fuel { get; set; }
        public Color Color { get; set; }
        public int PassengerOccupancy { get; set; }

        public void Refuel()
        {
            Fuel = 100;
        }

        public void ForwardMovement(string movementName, string vehicleType)
        {
            Fuel -= 10;

            if (Fuel <= 0)
            {
                Fuel = 0;
                Console.WriteLine("You are out of gas");
                return;
            }

            Console.WriteLine($"You {movementName} your {vehicleType} and now have {Fuel} gas left.");
        }

        public void Brake()
        {
            Console.WriteLine("You have stopped.");
        }
    }

    enum Color
    {
        Black,
        Blue,
        Grey,
        Red,
        White,
    }
}
