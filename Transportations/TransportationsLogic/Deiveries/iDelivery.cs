namespace TransportationsLogic.Deiveries
{
    public interface iDelivery
    {
        decimal Weight { get; set; }
        string StartAddress { get; set; }
        string DestinationAddress { get; set; }
        int Distance { get; set; }
        int RouteType { get; set; }
    }
}
