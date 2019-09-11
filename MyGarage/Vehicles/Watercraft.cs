using MyGarage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    class Watercraft : Vehicle, IDriver
    {
        public void Drive()
        {
            base.ForwardMovement("drive", "watercraft");
        }
    }
}
