
namespace CarDealerShip.Shared.Models
{
    public class Purchase
    {
        public int CarId { get; set; }
        public string BuyerName { get; set; }
        public int SellerId { get; set; }
        public decimal DealPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public virtual Car Car { get; set; }
        public virtual Seller Seller { get; set; } 
    }
}
