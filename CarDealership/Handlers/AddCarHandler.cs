using AutoMapper;
using CarDealership.Commands;
using CarDealership.Repository.Entities;
using CarDealership.Repository.Interfaces;
using CarDealerShip.Shared.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CarDealership.Handlers
{
    public class AddCarHandler : IRequestHandler<AddCarCommand, Car>
    {
        private readonly ICarsRepository _carRepository;
        private readonly IMapper _mapper;
        public AddCarHandler(ICarsRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<Car> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
            await _carRepository.AddCar(_mapper.Map<CarEntity>(request.car));
            return request.car;
        }
    }
}
