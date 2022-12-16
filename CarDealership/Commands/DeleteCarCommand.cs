using CarDealerShip.Shared.Models;
using MediatR;

namespace CarDealership.Commands
{
    public record DeleteCarCommand(Car car) : IRequest;
}
