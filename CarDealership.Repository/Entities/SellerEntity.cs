
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Repository.Entities
{
    public class SellerEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string City { get; set; }
        public decimal Bonuses { get; set; }
    }
}
