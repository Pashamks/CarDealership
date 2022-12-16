using CarDealership.Repository.Entities;
using CarDealership.Repository.Interfaces;

namespace CarDealership.Repository.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        private EfCoreDbContext GetContext()
        {
            return new EfCoreDbContext();
        }
        public async Task<CarEntity> AddCar(CarEntity car)
        {
            using(var ctx = GetContext())
            {
                ctx.Car.Add(car);
                await ctx.SaveChangesAsync();
                return car;
            }
        }

        public async Task DeleteCar(CarEntity car)
        {
            using (var ctx = GetContext())
            {
                car.Id = ctx.Car.First(x => x.Name == car.Name && x.Mark == car.Mark && x.FuelTankSize == car.FuelTankSize ).Id;
                ctx.Car.Remove(car);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<CarEntity> GetCarById(int Id)
        {
            using (var ctx = GetContext())
            {
                return ctx.Car.First(car => car.Id == Id);
            }
        }

        public async Task<List<CarEntity>> GetCars()
        {
            using (var ctx = GetContext())
            {
                return ctx.Car.ToList();
            }
        }

        public async Task<CarEntity> UpdateCar(CarEntity car)
        {
            using (var ctx = GetContext())
            {
                ctx.Car.Update(car);
                await ctx.SaveChangesAsync();
                return car;
            }
        }
    }
}
