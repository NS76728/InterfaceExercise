using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberoOfDoors { get; set; }
        public string Color { get; set; }
        public bool UsesGas { get; set; }




    }
}
