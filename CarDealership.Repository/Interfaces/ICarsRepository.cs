
using CarDealership.Repository.Entities;

namespace CarDealership.Repository.Interfaces
{
    public interface ICarsRepository
    {
        Task<List<CarEntity>> GetCars();
        Task<CarEntity> GetCarById(int Id);
        Task <CarEntity> AddCar(CarEntity car);
        Task <CarEntity> UpdateCar(CarEntity car);
        Task DeleteCar(CarEntity car);
        
    }
}
