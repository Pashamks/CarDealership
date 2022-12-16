using CarDealership.Commands;
using CarDealership.Queries;
using CarDealerShip.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ISender _sender;
        public CarsController(ISender sender)
        {
            _sender = sender;
        }
        [HttpGet]
        public async Task<ActionResult> GetCars()
        {
            var values = await _sender.Send(new GetCarsQuery());

            return Ok(values);
        }

        [HttpGet("{id:int}", Name = "GetCarById")]
        public async Task<ActionResult> GetValueById(int id)
        {
            var value = await _sender.Send(new GetCarByIdQuery(id));

            return Ok(value);
        }

        [HttpPost]
        public async Task<ActionResult> AddValue(Car car)
        {
            var addedValue = await _sender.Send(new AddCarCommand(car));
            return Ok(addedValue);
        }
    }
}
