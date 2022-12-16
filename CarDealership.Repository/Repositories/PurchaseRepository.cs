using CarDealership.Repository.Entities;
using CarDealership.Repository.Interfaces;

namespace CarDealership.Repository.Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private EfCoreDbContext GetContext()
        {
            return new EfCoreDbContext();
        }
        public async Task<PurchaseEntity> AddPurchase(PurchaseEntity purchase)
        {
            using (var ctx = GetContext())
            {
                ctx.Purchase.Add(purchase);
                //нарахування бонусів
                ctx.Seller.First(x => x.Id == purchase.SellerId).Bonuses += purchase.DealPrice/ 10000;
                await ctx.SaveChangesAsync();
                return purchase;
            }
        }

        public async Task DeletePurchase(PurchaseEntity purchase)
        {
            using (var ctx = GetContext())
            {
                ctx.Purchase.Remove(purchase);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<PurchaseEntity> GetPurchaseById(int Id)
        {
            using (var ctx = GetContext())
            {
                return ctx.Purchase.First(purchase => purchase.Id == Id);
            }
        }

        public async Task<List<PurchaseEntity>> GetPurchases()
        {
            using (var ctx = GetContext())
            {
                return ctx.Purchase.ToList();
            }
        }

        public async Task<PurchaseEntity> UpdatePurchase(PurchaseEntity purchase)
        {
            using (var ctx = GetContext())
            {
                ctx.Purchase.Update(purchase);
                await ctx.SaveChangesAsync();
                return purchase;
            }
        }
    }
}
