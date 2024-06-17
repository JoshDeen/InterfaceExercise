using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk {  get; set; }
        public bool HasFrontWheelDrive {  get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsDriveable { get; set; }
        public bool HasSteeringWheel { get; set; }
        public string Logo { get; set; }
        public bool HasTargetMarket { get; set; }
        public string MakesSound { get; set; }
        public void DisplayDetails() 
        {
            Console.WriteLine($"This car has a trunk, {HasTrunk}; and front wheel drive, {HasFrontWheelDrive}; " +
            $" It has {NumberOfWheels}, and is driveable, {IsDriveable}.  It has a {Logo} logo. " +
            $"It also has a steeringwheel, {HasSteeringWheel}; that makes a {MakesSound} sound"); 
        }
    }
}
