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
    public class AddPurchaseHandler : IRequestHandler<AddPurchaseCommand, Purchase>
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IMapper _mapper;
        public AddPurchaseHandler(IPurchaseRepository purchaseRepository, IMapper mapper)
        {
            _purchaseRepository = purchaseRepository;
            _mapper = mapper;
        }
        public async Task<Purchase> Handle(AddPurchaseCommand request, CancellationToken cancellationToken)
        {
            await _purchaseRepository.AddPurchase(_mapper.Map<PurchaseEntity>(request.purchase));
            return request.purchase;
        }
    }
}
