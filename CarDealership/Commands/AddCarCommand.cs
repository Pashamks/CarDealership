using CarDealerShip.Shared.Models;
using MediatR;

namespace CarDealership.Commands
{
    public record AddCarCommand(Car car) : IRequest<Car>;
}
