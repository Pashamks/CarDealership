using CarDealership.Repository.Enums;

namespace CarDealership.Repository.Entities
{
    public class CarEntity
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CreatedYear { get; set; }  
        public double FuelTankSize { get; set; }
        public CarType Type { get; set; }

    }
}
