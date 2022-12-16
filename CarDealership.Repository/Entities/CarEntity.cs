using CarDealership.Repository.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Repository.Entities
{
    public class CarEntity
    {
        [Required]
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int CreatedYear { get; set; }  
        public double FuelTankSize { get; set; }
        public CarType Type { get; set; }

    }
}
