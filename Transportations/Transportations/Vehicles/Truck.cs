using TransportationsLogic.Vehicles;
using TransportationsLogic.Deiveries;

namespace Transportations.Vehicles
{
    internal class Truck : iVehicle
    {
        public string VehicleName { get; set; }
        public int WeightLimit { get { return 50; } }
        public int DeliverySpeed { get { return 10; } }
        public int RoutesType { get { return 0; } }
        public decimal[,] Location { get; set; }
        public int VehicleLoad { get; set; }
        public List<iDelivery> DeliveriesLoaded { get; set; }
        public Truck (string  vehicleName) {
            this.VehicleName = vehicleName;
            
            }
    }
}
