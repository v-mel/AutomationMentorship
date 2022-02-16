using TransportationsLogic.Deiveries;

namespace Transportations.Deliveries
{
    internal class DeliveriesContainer
    {
        /// <summary>
        /// Container has vehicle number form Vehicles park, and Delivery instance
        /// </summary>
        public Dictionary<int, iDelivery> DeliveriesContainerDict { get; set; }

        /// <summary>
        /// Adds Delivery to DeliveriesContainer
        /// </summary>
        public void AddDelivery(int vehicleNumber, iDelivery deliveryToAdd) { }

        /// <summary>
        /// Removes Devlivery from DeliveriesContainer
        /// </summary>
        public void RemoveDelivery(iDelivery deliveryToRemove) { }

        /// <summary>
        /// Changes Vehicle for provided Delivery
        /// </summary>
        public void ChangeVehicle(int vehicleNumberToChange, iDelivery deliveryWithVehicleToBeChanged) { }

        /// <summary>
        ///lists all vehicles suitable for trasportation of current delivery
        /// </summary>
        public void ShowAvailableVehiclesForDelivery(int deliveryTonnage) { }
    }
}
