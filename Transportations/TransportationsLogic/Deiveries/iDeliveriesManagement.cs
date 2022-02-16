using TransportationsLogic.Vehicles;

namespace TransportationsLogic.Deiveries
{
    public  interface iDeliveriesManagement
    {
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
        public void CancelDelivery(Delivery deliveryToCancel) { }

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
        public iDelivery GetDeliveryByName(string deliveryName) { return null; }

        /// <summary>
        /// Finds and Prints all deliveries assigned to Vehicle
        /// </summary>
        public iVehicle GetDEliveriesForVehicle(string vehicleName) { return null; }
    }
}
