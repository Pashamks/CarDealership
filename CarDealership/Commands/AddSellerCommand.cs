using CarDealerShip.Shared.Models;
using MediatR;

namespace CarDealership.Commands
{
    public record AddSellerCommand(Seller seller) : IRequest<Seller>;
}
