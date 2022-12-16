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
        public Task<CarEntity> AddCar(CarEntity car)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCar(CarEntity car)
        {
            throw new NotImplementedException();
        }

        public Task<CarEntity> GetCarById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarEntity>> GetCars()
        {
            throw new NotImplementedException();
        }

        public Task<CarEntity> UpdateCar(CarEntity car)
        {
            throw new NotImplementedException();
        }
    }
}
