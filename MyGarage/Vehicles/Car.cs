using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    class Car : Vehicle
    {
        public void Drive ()
        {
            base.ForwardMovement("drive");
        }
    }
}
