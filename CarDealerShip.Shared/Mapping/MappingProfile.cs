
using AutoMapper;
using CarDealership.Repository.Entities;
using CarDealerShip.Shared.Models;

namespace CarDealerShip.Shared.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarEntity>();
            CreateMap<CarEntity, Car>();
        }
    }
}
