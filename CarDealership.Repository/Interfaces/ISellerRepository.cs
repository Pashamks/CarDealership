using CarDealership.Repository.Entities;

namespace CarDealership.Repository.Interfaces
{
    public interface ISellerRepository
    {
        Task<List<SellerEntity>> GetSellers();
        Task<SellerEntity> GetSellerById(int Id);
        Task<SellerEntity> AddSeller(SellerEntity seller);
        Task<SellerEntity> UpdateSeller(SellerEntity seller);
        Task DeleteSeller(SellerEntity seller);
    }
}
