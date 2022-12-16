using CarDealerShip.Shared.Models;
using MediatR;
using System.Collections.Generic;

namespace CarDealership.Queries
{
    public record GetCarsQuery : IRequest<List<Car>>;

}
