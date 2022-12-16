using CarDealerShip.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly ISender _sender;
        public PurchaseController(ISender sender)
        {
            _sender = sender;
        }
      
        [HttpGet]
        public async Task<ActionResult> GetSoldCars()
        {
            var values = await _sender.Send(new GetSoldCarsQuery());

            return Ok(values);
        }


        [HttpPost]
        public async Task<ActionResult> AddPurchase(Purchase purchase)
        {
            var addedPurchase = await _sender.Send(new AddPurchaseCommand(purchase));
            return Ok(addedPurchase);
        }


    }
}
