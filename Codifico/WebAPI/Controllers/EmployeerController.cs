using Codifico.WebAPI.Interfaces;
using Codifico.WebAPI.Interfaces.Business;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Microsoft.AspNetCore.Mvc;

namespace Codifico.WebAPI.Controllers
{
    public class EmployeerController : Controller
    {
        private readonly EmployeeServices _EmployeeService;

        public EmployeerController(EmployeeServices employeeService)
        {
            _EmployeeService = employeeService;
        }

        [HttpGet("Employee")]
        public IEnumerable<EmployeeDropDown> GetUsers()
        {
            return _EmployeeService.GetAllUsers();
        }
    }
}
