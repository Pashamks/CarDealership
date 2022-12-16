using AutoMapper;
using CarDealership.Queries;
using CarDealership.Repository.Interfaces;
using CarDealerShip.Shared.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CarDealership.Handlers
{
    public class GetCarByIdHandler : IRequestHandler<GetCarByIdQuery, Car>
    {
        private readonly ICarsRepository _carsRepository;
        private readonly IMapper _mapper;
        public GetCarByIdHandler(ICarsRepository carsRepository, IMapper mapper)
        {
            _carsRepository = carsRepository;
            _mapper = mapper;
        }
        public async Task<Car> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<Car>(await _carsRepository.GetCarById(request.Id));
        }
    }
}
