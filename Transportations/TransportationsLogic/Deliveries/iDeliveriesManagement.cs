using TransportationsLogic.Vehicles;

namespace TransportationsLogic.Deiveries
{
    public  interface iDeliveriesManagement
    {
        /// <summary>
        /// Calculates time needed for delivery
        /// </summary>
        DateTime CalculateDeliveryTime(iDelivery delivery);

        /// <summary>
        /// Starts new Delivery in ActiveDeliveries using user input
        /// </summary>
        void StartDelivery();

        /// <summary>
        /// Moves Delivery from ActiveDeliveries to FinishedDeliveries
        /// </summary>
        void FinishDelivery(iDelivery deliveryToFinish);
        /// <summary>
        /// Moves Delivery from ActiveDeliveries to CancelledDeliveries
        /// </summary>
        void CancelDelivery(iDelivery deliveryToCancel);

        /// <summary>
        ///Prints all active Deliveries
        /// </summary>
        void ListActiveDeliveries();

        /// <summary>
        /// Prints all Finished Deliveries
        /// </summary>
        void ListFinishedDeliveries();

        /// <summary>
        /// Prints all Cancelled Deliveries
        /// </summary>
        void ListCancelledliveries();

        /// <summary>
        /// Finds and Prints Delivery by it's name
        /// </summary>
        iDelivery GetDeliveryByName(string deliveryName);

        /// <summary>
        /// Finds and Prints all deliveries assigned to Vehicle
        /// </summary>
        iVehicle GetDEliveriesForVehicle(string vehicleName);
    }
}
