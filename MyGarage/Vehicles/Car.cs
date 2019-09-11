using MyGarage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    abstract class Car : Vehicle, IDriver
    {
        public abstract bool hasAutoHighBeams { get; }
        public abstract bool hasHeatedSteeringWheel { get; }
        public abstract bool hasAutoEmergencyBraking { get; }
        public abstract bool hasAdaptiveCruiseControl { get; }
        public abstract bool hasPushButtonStart { get; }
        public abstract bool hasPassiveEntry { get; }
        public string CarName;

        public void Drive ()
        {
            base.ForwardMovement("drive", "car");
        }

        public void ListFeatures()
        {
            Console.WriteLine($"Your {CarName} {(hasAutoHighBeams ? "has" : "does not have")} automatic high beams");
        }
    }
}
