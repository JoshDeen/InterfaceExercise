using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasTruckBed {  get; set; }
        public bool HasRollBar {  get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsDriveable { get; set; }
        public bool HasSteeringWheel { get; set; }
        public string Logo { get; set; }
        public bool HasTargetMarket { get; set; }
        public string MakesSound { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"This truck has a truckbed, {HasTruckBed}; with a rollbar, {HasRollBar};" +
            $" and has {NumberOfWheels} wheels.  It is driveable, {IsDriveable}; with its steering wheel," +
            $"{HasSteeringWheel}; with logo {Logo} that makes a {MakesSound} sound.");
        }
    
    }
}
