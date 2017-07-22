using System;
using vehicles;

namespace vechiles
{
    public class Delorean : IGroundVehicle, IDrivableVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Flux Capacitor";
        public double EngineVolume { get; set; } = 1.11;
        public double MaxSpeed { get; set; } = 88;

        public void Drive()
        {
            Console.WriteLine("When this baby hits 88mph you're going to see some crazy shit!");
        }

        public void Start()
        {
            Console.WriteLine("Poop");
        }

        public void Stop()
        {
            Console.WriteLine("What the hell");
        }
    }
}