using Codifico.WebAPI.DataBase;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Microsoft.EntityFrameworkCore;

namespace Codifico.WebAPI.Repository.Persistency
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly AppDbContext _context;


        public ProductsRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ProductDropDown> ObtenerTodos()
        {
            var lista = _context.ProductDropdown.FromSqlRaw("EXEC ProductDropDown").ToList();
            return lista;
        }

    }

}
