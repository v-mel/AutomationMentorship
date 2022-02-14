namespace Transportations
{
    public class Delivery
    {   
        public decimal Weight { get; set; }
        public string StartAddress { get; set; }
        public string DestinationAddress { get; set; }
        public int Distance { get; set; }

        public Delivery(decimal weigt, string startAddress, string destinationAddress) 
        {
            this.Weight = weigt;
            this .StartAddress = startAddress;
            this .DestinationAddress = destinationAddress;
            this.Distance = Distance;
        }


    }
}