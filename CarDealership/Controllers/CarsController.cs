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
        public async Task<ActionResult> GetCarById(int id)
        {
            var value = await _sender.Send(new GetCarByIdQuery(id));

            return Ok(value);
        }

        [HttpPost]
        public async Task<ActionResult> AddCar(Car car)
        {
            var addedCar = await _sender.Send(new AddCarCommand(car));
            return Ok(addedCar);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCar(Car car)
        {
            await _sender.Send(new UpdateCarCommand(car));
            return Ok(201);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCar(Car car)
        {
            await _sender.Send(new DeleteCarCommand(car));
            return Ok(201);
        }
    }
}
