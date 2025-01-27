using Codifico.WebAPI.DataBase;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Microsoft.EntityFrameworkCore;

namespace Codifico.WebAPI.Repository.Persistency
{
    public class ShipperRepository : IShipperRepository
    {
        private readonly AppDbContext _context;


        public ShipperRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ShipperDropDown> ObtenerTodos()
        {
            var lista = _context.ShipperDropdown.FromSqlRaw("EXEC ShipperDropdown").ToList();
            return lista;
        }

    }

}
