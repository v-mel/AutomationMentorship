using TransportationsLogic.Deiveries;

namespace TransportationsLogic.Vehicles
{
    public  interface iVehicle
    {
        string VehicleName { get; set; }
        /// <summary>
        /// Weight limit is:
        /// 50 - trucks;
        /// 500 - plane;
        /// 165 000 - container ship;
        /// </summary>
        static int weightLimit;
        /// <summary>
        /// Delivery Speed is:
        /// 10 - trucks;
        /// 30 - plane;
        /// 5 - container ship;
        /// </summary>
        static int deliverySpeed;
        /// <summary>
        /// Routes types between 2 points:
        /// 0 - trucks;
        /// 1 - plane;
        /// 2 - container ship;
        /// </summary>
        static int routesType;
        /// <summary>
        /// geogrepahical absolute location represented
        /// as pair of 2 decimal numbers
        /// </summary>
        decimal[,] Location { get; set; }
        /// <summary>
        /// percentage of how much vehicle is loaded by deliveries
        /// </summary>
        int VehicleLoad { get; set; }
        List<iDelivery> DeliveriesLoaded { get; set; }

    }
}
