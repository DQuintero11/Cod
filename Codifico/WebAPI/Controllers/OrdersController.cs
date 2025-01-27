using Codifico.WebAPI.Interfaces;
using Codifico.WebAPI.Interfaces.Business;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Codifico.WebAPI.Objects.Request;
using Microsoft.AspNetCore.Mvc;

namespace Codifico.WebAPI.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrdersServices _OrdersService;

        public OrdersController(OrdersServices ordersService)
        {
            _OrdersService = ordersService;
        }

        [HttpGet("OrdersView")]
        public IEnumerable<OrdersView> OrderByCustomers(RequestOrders _objRequestOrderByCustomer)
        {

            return _OrdersService.OrderByCustomers(_objRequestOrderByCustomer);

        }

        [HttpPost("Orders")]
        public IActionResult CreateOrderAndDetails([FromBody] RequestOrdersCreate _objCreate)
        {
            var result =_OrdersService.CreateOrderAndDetails(_objCreate);
            return CreatedAtAction(nameof(Orders), new { id = _objCreate.orderid }, _objCreate);

        }


        [HttpGet("OrderPrediction")]
        public IEnumerable<OrdersPrediction> OrderPrediction()
        {
            return _OrdersService.OrderPrediction();
        }
    }
}
