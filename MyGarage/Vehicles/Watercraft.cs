using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    class Watercraft : Vehicle
    {
        public void Drive()
        {
            base.ForwardMovement("drive", "watercraft");
        }
    }
}
