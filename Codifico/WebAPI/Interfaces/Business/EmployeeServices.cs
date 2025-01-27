using Codifico.WebAPI.Interfaces;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Codifico.WebAPI.Repository;
using System.Buffers.Text;

namespace Codifico.WebAPI.Interfaces.Business
{
    public class EmployeeServices 
    {


        private readonly IEmployeeRepository _employeeService;

        public EmployeeServices(IEmployeeRepository employeeService)
        {
            _employeeService = employeeService;
        }

        public List<EmployeeDropDown> GetAllUsers()
        {
            var listEmployee = _employeeService.ObtenerTodos();

            return listEmployee;
        }


    }
}



