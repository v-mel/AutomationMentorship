using TransportationsLogic.Vehicles;

namespace Transportations.Vehicles
{
    public class VehiclesPark
    {
        public Dictionary<int, iVehicle> VehiclesList { get; set; }

        /// <summary>
        /// Adds Vehicle to Vehicle park by user input
        /// </summary>
        public void AddVehicle() { }

        /// <summary>
        /// Removes Vehicle from Vehicles park
        /// </summary>
        public void RemoveVehicle(iVehicle newVehicleToRemove){ }

        /// <summary>
        /// Removes Vehicle from Vehicles park by it's name
        /// </summary>
        public void RemoveVehicle(string  vehicleName) { }

        /// <summary>
        /// Removes Vehicle from Vehicles park by it's id in VehiclesList
        /// </summary>
        public void RemoveVehicle(int) { };


    }
}
