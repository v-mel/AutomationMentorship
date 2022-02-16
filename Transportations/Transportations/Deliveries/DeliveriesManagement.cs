using TransportationsLogic.Deiveries;
using Transportations.Vehicles;

namespace Transportations.Deliveries
{
    internal class DeliveriesManagement
    {
        public DeliveriesContainer ActiveDeliveries { get; set; }
        public DeliveriesContainer FinishdedDeliveries { get; set; }
        public DeliveriesContainer CancelledDeliveries { get; set; }

        /// <summary>
        /// Calculates time needed for delivery
        /// </summary>
        DateTime CalculateDeliveryTime(iDelivery delivery) { return DateTime.UtcNow; }

        /// <summary>
        /// Starts new Delivery in ActiveDeliveries using user input
        /// </summary>
        public void StartDelivery() { }

        /// <summary>
        /// Moves Delivery from ActiveDeliveries to FinishedDeliveries
        /// </summary>
        public void FinishDelivery(Delivery deliveryToFinish) { }
        /// <summary>
        /// Moves Delivery from ActiveDeliveries to CancelledDeliveries
        /// </summary>
        public void CancelDelivery( Delivery deliveryToCancel) {  }

        /// <summary>
        ///Prints all active Deliveries
        /// </summary>
        public void ListActiveDeliveries() { }

        /// <summary>
        /// Prints all Finished Deliveries
        /// </summary>
        public void ListFinishedDeliveries() { }

        /// <summary>
        /// Prints all Cancelled Deliveries
        /// </summary>
        public void ListCancelledliveries() { }

        /// <summary>
        /// Finds and Prints Delivery by it's name
        /// </summary>
        public Delivery GetDeliveryByName(string deliveryName) { return null; }

        /// <summary>
        /// Finds and Prints all deliveries assigned to Vehicle
        /// </summary>
        public Vehicle GetDEliveriesForVehicle(string vehicleName) { return null; }
    }
}
