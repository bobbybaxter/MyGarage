using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    class Aircraft : Vehicle
    {
        public void Fly()
        {
            base.ForwardMovement("fly", "aircraft");
        }
    }
}
