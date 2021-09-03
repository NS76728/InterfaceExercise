using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public bool IsCompact { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberoOfDoors { get; set; }
        public string Color { get; set; }
        public bool UsesGas { get; set; }

        public string Logo { get; set; }
        public string CorpAcronym { get; set; }

        public Car()
        {
        }

        public void printStats()
        {
            Console.WriteLine($"Your cars stats: Logo:{Logo}, Company:{CorpAcronym}, Number of wheels:{NumberOfWheels}, Number of doors:{NumberoOfDoors}, Color:{Color}, uses gas:{UsesGas}, Has trunk:{HasTrunk}, Is Compact:{IsCompact}");

        }






    }
}
