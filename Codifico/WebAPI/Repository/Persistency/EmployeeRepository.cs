using Codifico.WebAPI.DataBase;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Microsoft.EntityFrameworkCore;

namespace Codifico.WebAPI.Repository.Persistency
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;


        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<EmployeeDropDown> ObtenerTodos()
        {
            var lista = _context.EmployeeDropdown.FromSqlRaw("EXEC EmployeeDropDown").ToList();
            return lista;
        }

    }


}


