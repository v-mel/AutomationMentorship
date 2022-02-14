
namespace Transportations
{
    public class Vehicle
    {

        public string vehicleName;
        public readonly int tonnage;
        public readonly string vin;
        public int Speed { get; set; }
        public decimal[,] Location { get; set; }

        public Vehicle(string name, int tonnage, string vin)
        {
            this.vehicleName = name;
            this.tonnage = tonnage;
            this.vin = vin;
        }
    }
}
