using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
            //Create 2 Interfaces called IVehicle & ICompany
            //Create 3 classes called Car , Truck , & SUV
            //In your IVehicle
            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */
            //In ICompany
            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */
            //In each of your car, truck, and suv classes
            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car1 = new Car();
            car1.Logo = "Ford";
            car1.CorpAcronym = "FOMCO";
            car1.NumberOfWheels = 4;
            car1.NumberoOfDoors = 4;
            car1.HasTrunk = true;
            car1.IsCompact = true;
            car1.UsesGas = true;
            car1.Color = "Blue";
            car1.printStats();
            Console.WriteLine("----------------------------------------------------------------");
            var truck1 = new Truck();
            truck1.Logo = "Ford";
            truck1.CorpAcronym = "FOMCO";
            truck1.NumberOfWheels = 6;
            truck1.NumberoOfDoors = 4;
            truck1.HasBedCover = true;
            truck1.UsesGas = false;
            truck1.Color = "red";
            truck1.BedLength = 10;
            truck1.printStats();
            Console.WriteLine("----------------------------------------------------------------");
            var suv1 = new SUV();
            suv1.Logo = "Toyota";
            suv1.CorpAcronym = "TM";
            suv1.NumberOfWheels = 4;
            suv1.NumberoOfDoors = 4;
            suv1.UsesGas = true;
            suv1.Color = "Black";
            suv1.NumberofSeats = 8;
            suv1.CargoHoldSize = 20;
            suv1.printStats();
            Console.WriteLine("----------------------------------------------------------------");






        }
    }
}
