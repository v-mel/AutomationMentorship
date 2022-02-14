
namespace Transportations
{
    internal class DeliveriesManagement
    {
        DeliveriesContainer activeDeliveries;
        DeliveriesContainer finishdedDeliveries;
        DeliveriesContainer cancelledDeliveries;

        public void StartDelivery() { } // will work with activeDeliveries, user input will be needed
        public void FinishDelivery(Delivery deliveryToFinish) { }// will work with activeDeliveries, finishedDeliveries
        public void CancelDelivery( Delivery deliveryToCancel) {  }// will work with activeDeliveries, cancelledDeliveries

        public void ListActiveDeliveries() { }
        public void ListFinishedDeliveries() { }
        public void ListCancelledliveries() { }

        public Delivery GetDeliveryByName(string deliveryName) { return null; }
        public Vehicle GetDEliveriesForVehicle(string vehicleName) { return null; }
    }
}
