using Codifico.WebAPI.Interfaces;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Microsoft.AspNetCore.Mvc;

namespace Codifico.WebAPI.Controllers
{
    public class ShippersController : Controller
    {
        private readonly ShipperServices _ShippersService;

        public ShippersController(ShipperServices shipperService)
        {
            _ShippersService = shipperService;
        }

        [HttpGet("Shipper")]
        public IEnumerable<ShipperDropDown> GetUsers()
        {
            return _ShippersService.GetAllUsers();
        }
    }
}
