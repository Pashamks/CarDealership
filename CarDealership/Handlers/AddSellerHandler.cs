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
    public class AddSellerHandler : IRequestHandler<AddSellerCommand, Seller>
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly IMapper _mapper;
        public AddSellerHandler(ISellerRepository sellerRepository, IMapper mapper)
        {
            _sellerRepository = sellerRepository;
            _mapper = mapper;
        }
        public async Task<Seller> Handle(AddSellerCommand request, CancellationToken cancellationToken)
        {
            await _sellerRepository.AddSeller(_mapper.Map<SellerEntity>(request.seller));
            return request.seller;
        }
    }
}
