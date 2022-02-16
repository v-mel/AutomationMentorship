using Transportations.Deliveries;
using Transportations.Vehicles;

namespace Transportations;
class TransportationsMain
{
    static void Main(string[] args)
    {
        DeliveriesManagement deliveries = new DeliveriesManagement();
        deliveries.StartDelivery();
    }
}