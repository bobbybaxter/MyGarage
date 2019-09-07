using MyGarage.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Garage
{
    class HondaAccord : Car
    {
        public override bool hasAutoHighBeams => false;
        public override bool hasHeatedSteeringWheel => true;
        public override bool hasAutoEmergencyBraking => false;
        public override bool hasAdaptiveCruiseControl => true;
        public override bool hasPushButtonStart => false;
        public override bool hasPassiveEntry => true;

        public HondaAccord()
        {
            CarName = "Honda Accord";
        }
    }
}
