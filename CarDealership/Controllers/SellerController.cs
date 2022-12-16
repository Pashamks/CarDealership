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
    public class SellerController : ControllerBase
    {
        private readonly ISender _sender;
        public SellerController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<ActionResult> GetSellers()
        {
            var sellers = await _sender.Send(new GetSellersQuery());

            return Ok(sellers);
        }


        [HttpPost]
        public async Task<ActionResult> AddSeller(Seller seller)
        {
            var addedSeller = await _sender.Send(new AddSellerCommand(seller));
            return Ok(addedSeller);
        }
    }
}
