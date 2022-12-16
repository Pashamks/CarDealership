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
    public class GetSellersHandler : IRequestHandler<GetSellersQuery, List<Seller>>
    {
        private readonly ISellerRepository _sellersRepository;
        private readonly IMapper _mapper;
        public GetSellersHandler(ISellerRepository sellerRepository, IMapper mapper)
        {
            _sellersRepository = sellerRepository;
            _mapper = mapper;
        }
        public async Task<List<Seller>> Handle(GetSellersQuery request, CancellationToken cancellationToken)
        {
            return (await _sellersRepository.GetSellers()).Select(x => _mapper.Map<Seller>(x)).ToList();
        }
    }
}