using MyGarage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    class Aircraft : Vehicle, IFlyer
    {
        public void Fly()
        {
            base.ForwardMovement("fly", "aircraft");
        }
    }
}
