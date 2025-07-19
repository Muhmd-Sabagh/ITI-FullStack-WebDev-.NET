using CarAPI.Entities;
using CarAPI.Models;
using CarAPI.Services_BLL;
using Microsoft.AspNetCore.Mvc;

namespace CarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnersController : ControllerBase
    {
        private readonly IOwnersService _ownersService;
        public OwnersController(IOwnersService ownersService)
        {
            _ownersService = ownersService;
        }

        [HttpGet]
        public List<Owner> Get()
        {
            return _ownersService.GetOwners();
        }

        [HttpGet]
        [Route("{id:int}")]
        public Owner Get(int id)
        {
            return _ownersService.GetById(id);
        }

        [HttpPost]
        public bool Post([FromBody] Owner owner)
        {
            return _ownersService.AddOwner(owner);
        }

        [HttpPost]
        public string BuyCar([FromBody] BuyCarInput input)
        {
            return _ownersService.BuyCar(input);
        }
    }
}
