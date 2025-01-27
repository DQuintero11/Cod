using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Codifico.WebAPI.Repository;

namespace Codifico.WebAPI.Interfaces.Business
{
    public class ProductsServices 
    {


        private readonly IProductsRepository _productsService;

        public ProductsServices(IProductsRepository productService)
        {
            _productsService = productService;
        }



       public List<ProductDropDown> GetAllUsers()
        {
            var listProducts = _productsService.ObtenerTodos();

            return listProducts;
        }

    }
}
