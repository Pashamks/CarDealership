using CarDealerShip.Shared.Models;
using MediatR;

namespace CarDealership.Queries
{
    public record GetCarByIdQuery(int Id) : IRequest<Car>;
}
