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
    public class DeleteCarHandler : IRequestHandler<DeleteCarCommand>
    {
        private readonly ICarsRepository _carRepository;
        private readonly IMapper _mapper;
        public DeleteCarHandler(ICarsRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            await _carRepository.DeleteCar(_mapper.Map<CarEntity>(request.car));
            return Unit.Value;
        }

    }
}
