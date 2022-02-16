using TransportationsLogic.Vehicles;
using TransportationsLogic.Deiveries;

namespace Transportations.Vehicles
{
    internal class Plane : iVehicle
    {
        public string VehicleName { get; set; }
        static public int weightLimit =0;
        static public int deliverySpeed =10;
        static public int routesType = 50;
        public decimal[,] Location { get; set; }
        public int VehicleLoad { get; set; }
        public List<iDelivery> DeliveriesLoaded { get; set; }
        public Plane (string  vehicleName) {
            this.VehicleName = vehicleName;
            
            }
    }
}
