using Codifico.WebAPI.Interfaces;
using Codifico.WebAPI.Interfaces.Business;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Microsoft.AspNetCore.Mvc;

namespace Codifico.WebAPI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsServices _ProductsService;

        public ProductsController(ProductsServices productsService)
        {
            _ProductsService = productsService;
        }

        [HttpGet("Products")]
        public IEnumerable<ProductDropDown> GetUsers()
        {
            return _ProductsService.GetAllUsers();
        }
    }
}
