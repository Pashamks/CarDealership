using CarDealerShip.Shared.Models;
using MediatR;

namespace CarDealership.Commands
{
    public record AddPurchaseCommand(Purchase purchase) : IRequest<Purchase>;
}
