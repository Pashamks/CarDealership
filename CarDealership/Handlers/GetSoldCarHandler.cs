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
    public class GetSoldHandler : IRequestHandler<GetCarsQuery, List<Car>>
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly ICarsRepository _carsRepository;
        private readonly IMapper _mapper;
        public GetSoldHandler(IPurchaseRepository purchaseRepository, ICarsRepository carsRepository, IMapper mapper)
        {
            _purchaseRepository = purchaseRepository;
            _carsRepository = carsRepository;
            _mapper = mapper;
        }
        public async Task<List<Car>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
        {
            return (await _purchaseRepository.GetPurchases())
                .Select(x => _mapper.Map<Car>(_carsRepository.GetCarById(x.CarId)))
                .ToList();
        }
    }
}
