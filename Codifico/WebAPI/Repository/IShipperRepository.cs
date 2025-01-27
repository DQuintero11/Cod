using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;

namespace Codifico.WebAPI.Repository
{
    public interface IShipperRepository
    {
        List<ShipperDropDown> ObtenerTodos();
    }
}
