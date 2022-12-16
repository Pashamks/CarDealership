
using CarDealership.Repository.Enums;

namespace CarDealerShip.Shared.Models
{
    public class Car
    {
        public string Mark { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CreatedYear { get; set; }
        public double FuelTankSize { get; set; }
        public CarType Type { get; set; }
    }
}
