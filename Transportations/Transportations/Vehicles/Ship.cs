using TransportationsLogic.Vehicles;
using TransportationsLogic.Deiveries;

namespace Transportations.Vehicles
{
    internal class Ship : iVehicle
    {
        public string VehicleName { get; set; }
        public int WeightLimit { get { return 165000; } }
        public int DeliverySpeed { get { return 5; } }
        public int RoutesType { get { return 2; } }
        public decimal[,] Location { get; set; }
        public int VehicleLoad { get; set; }
        public List<iDelivery> DeliveriesLoaded { get; set; }
        public Ship(string vehicleName)
        {
            this.VehicleName = vehicleName;

        }
    }
}
