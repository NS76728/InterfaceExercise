using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public int NumberofSeats { get; set; }
        public int CargoHoldSize { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberoOfDoors { get; set; }
        public string Color { get; set; }
        public bool UsesGas { get; set; }

        public string Logo { get; set; }
        public string CorpAcronym { get; set; }

        public SUV()
        {

        }

        public void printStats()
        {
            Console.WriteLine($"Your trucks stats: Logo:{Logo}, Company:{CorpAcronym}, Number of wheels:{NumberOfWheels}, Number of doors:{NumberoOfDoors}, Color:{Color}, uses gas:{UsesGas}, Number of seats:{NumberofSeats}, Cargo hold size:{CargoHoldSize}");

        }

    }
}
