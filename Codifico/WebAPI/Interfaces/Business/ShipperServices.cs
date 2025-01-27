using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Codifico.WebAPI.Repository;

namespace Codifico.WebAPI.Interfaces
{
    public class ShipperServices 
    {


        private readonly IShipperRepository _shipperService;

        public ShipperServices(IShipperRepository shipperService)
        {
            _shipperService = shipperService;
        }



        public List<ShipperDropDown> GetAllUsers()
        {
            var listShippers = _shipperService.ObtenerTodos();

            return listShippers;
        }

    }
}
