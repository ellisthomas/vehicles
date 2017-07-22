using System;
using vehicles;

namespace vechiles
{
    public class RowBeat : IWaterVehicle
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } 
        public double EngineVolume { get; set; } = 1.0;
        public double MaxSpeed { get; set; } = 11;

        public void Start()
        {
            Console.Write("Get ta paddling");
        }
    }


}