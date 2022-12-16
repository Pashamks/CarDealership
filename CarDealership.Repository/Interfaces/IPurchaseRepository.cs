using CarDealership.Repository.Entities;

namespace CarDealership.Repository.Interfaces
{
    public interface IPurchaseRepository
    {
        Task<List<PurchaseEntity>> GetPurchases();
        Task<PurchaseEntity> GetPurchaseById(int Id);
        Task<PurchaseEntity> AddPurchase(PurchaseEntity purchase);
        Task<PurchaseEntity> UpdatePurchase(PurchaseEntity purchase);
        Task DeletePurchase(PurchaseEntity purchase);
    }
}
