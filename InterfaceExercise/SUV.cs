using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int NumberOfSeats {  get; set; }
        public bool HasAllWheelDrive {  get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsDriveable { get; set; }
        public bool HasSteeringWheel { get; set; }
        public string Logo { get; set; }
        public bool HasTargetMarket { get; set; }
        public string MakesSound { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"This SUV has {NumberOfSeats} number of seats and it has All Wheel Drive {HasAllWheelDrive}.  It has 4 doors and {NumberOfWheels} wheels" +
            $"It is driveable {IsDriveable} and has a steeringwheel {HasSteeringWheel} with a {Logo} logo and target market {HasTargetMarket} with a sound of{MakesSound}");
        }

    }
}
