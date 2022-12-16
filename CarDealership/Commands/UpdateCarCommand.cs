using CarDealerShip.Shared.Models;
using MediatR;

namespace CarDealership.Commands
{
    public record UpdateCarCommand(Car car) : IRequest<Car>;
}
