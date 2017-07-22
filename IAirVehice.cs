namespace vehicles
{
    public interface IAirVehice : IVehicle
    {
        double MaxSpeed { get; set; }
        bool Winged { get; set; }
        void Fly();
        void Land();
    }

}