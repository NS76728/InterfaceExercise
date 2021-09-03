using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public int BedLength { get; set; }
        public bool HasBedCover { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberoOfDoors { get; set; }
        public string Color { get; set; }
        public bool UsesGas { get; set; }

        public string Logo { get; set; }
        public string CorpAcronym { get; set; }

        public Truck()
        {

        }

        public void printStats()
        {
            Console.WriteLine($"Your trucks stats: Logo:{Logo}, Company:{CorpAcronym}, Number of wheels:{NumberOfWheels}, Number of doors:{NumberoOfDoors}, Color:{Color}, uses gas:{UsesGas}, Has bed cover:{HasBedCover}, Bed Length:{BedLength}");

        }



    }
}
