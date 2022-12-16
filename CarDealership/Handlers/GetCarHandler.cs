using AutoMapper;
using CarDealership.Queries;
using CarDealership.Repository.Interfaces;
using CarDealerShip.Shared.Models;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarDealership.Handlers
{
    public class GetValueHandler : IRequestHandler<GetCarsQuery, List<Car>>
    {
        private readonly ICarsRepository _carsRepository;
        private readonly IMapper _mapper;
        public GetValueHandler(ICarsRepository carsRepository, IMapper mapper)
        {
            _carsRepository = carsRepository;
            _mapper = mapper;
        }
        public async Task<List<Car>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
        {
            return (await _carsRepository.GetCars()).Select(x => _mapper.Map<Car>(x)).ToList();
        }
    }
}
