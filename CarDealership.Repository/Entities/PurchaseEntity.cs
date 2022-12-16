
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealership.Repository.Entities
{
    public class PurchaseEntity
    {
        [Required]
        public int Id { get; set; }
        [ForeignKey("Car")]
        public int CarId {get; set;}
        public string BuyerName { get; set; }
        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public decimal DealPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
