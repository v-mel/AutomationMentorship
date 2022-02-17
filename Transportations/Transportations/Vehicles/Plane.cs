using TransportationsLogic.Vehicles;
using TransportationsLogic.Deiveries;

namespace Transportations.Vehicles
{
    internal class Plane : iVehicle
    {
        public string VehicleName { get; set; }
        public int WeightLimit { get { return 500; } }
        public int DeliverySpeed { get { return 30; } } 
        public int RoutesType { get { return 1; } }
        public decimal[,] Location { get; set; }
        public int VehicleLoad { get; set; }
        public List<iDelivery> DeliveriesLoaded { get; set; }
        public Plane (string  vehicleName) {
            this.VehicleName = vehicleName;
            }
    }
}
