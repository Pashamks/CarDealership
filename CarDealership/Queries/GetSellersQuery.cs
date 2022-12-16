using CarDealerShip.Shared.Models;
using MediatR;
using System.Collections.Generic;

namespace CarDealership.Queries
{
    public record GetSellersQuery : IRequest<List<Seller>>;
}
