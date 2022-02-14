namespace Transportations
{
    internal class DeliveriesContainer
    {
        /// Container has vehicle number form Vehicles park, and Delivery instance
        public Dictionary<int, Delivery> deliveriesContainer; 
     
        public void AddDelivery(int vehicleNumber, Delivery deliveryToAdd) {  }
        public void RemoveDelivery( Delivery deliveryToRemove) {  }
        public void ChangeVehicle(int vehicleNumberToChange, Delivery deliveryWithVehicleToBeChanged) { }
    }
}
