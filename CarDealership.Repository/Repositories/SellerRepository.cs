
using CarDealership.Repository.Entities;
using CarDealership.Repository.Interfaces;

namespace CarDealership.Repository.Repositories
{
    public class SellerRepository : ISellerRepository
    {
        private EfCoreDbContext GetContext()
        {
            return new EfCoreDbContext();
        }
        public async Task<SellerEntity> AddSeller(SellerEntity seller)
        {
            using (var ctx = GetContext())
            {
                ctx.Seller.Add(seller);
                await ctx.SaveChangesAsync();
                return seller;
            }
        }

        public async Task DeleteSeller(SellerEntity seller)
        {
            using (var ctx = GetContext())
            {
                ctx.Seller.Remove(seller);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<SellerEntity> GetSellerById(int Id)
        {
            using (var ctx = GetContext())
            {
                return ctx.Seller.First(seller => seller.Id == Id);
            }
        }

        public async Task<List<SellerEntity>> GetSellers()
        {
            using (var ctx = GetContext())
            {
                return ctx.Seller.ToList();
            }
        }

        public async Task<SellerEntity> UpdateSeller(SellerEntity seller)
        {
            using (var ctx = GetContext())
            {
                ctx.Seller.Update(seller);
                await ctx.SaveChangesAsync();
                return seller;
            }
        }
    }
}
