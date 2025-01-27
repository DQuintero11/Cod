using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Codifico.WebAPI.Objects.Request;
using Codifico.WebAPI.Repository;

namespace Codifico.WebAPI.Interfaces.Business
{

    public class OrdersServices 
    {


        private readonly IOrdersRepository _OrdersService;

        public OrdersServices(IOrdersRepository ordersService)
        {
            _OrdersService = ordersService;
        }


        public List<OrdersView> OrderByCustomers( RequestOrders _objRequestOrderByCustomer)
        {
            var listProducts = _OrdersService.FilterOrdersByCustomers(_objRequestOrderByCustomer);

            return listProducts;
        }


        public List<OrdersPrediction> OrderPrediction()
        {
            List<OrdersPrediction> predictionList = _OrdersService.OrderPrediction();

            return predictionList;
        }

       public bool CreateOrderAndDetails(RequestOrdersCreate _objCreate)
        {

            Orders itemOrder = new Orders();

            itemOrder.orderid = _objCreate.orderid;
            itemOrder.custid = _objCreate.custid;
            itemOrder.empid = _objCreate.empid;
            itemOrder.orderdate = _objCreate.orderdate;
            itemOrder.requireddate = _objCreate.requireddate;
            itemOrder.shippeddate = _objCreate.shippeddate;
            itemOrder.shipperid = _objCreate.shipperid;
            itemOrder.freight = _objCreate.freight;
            itemOrder.shipname = _objCreate.shipname;
            itemOrder.shipaddress = _objCreate.shipaddress;
            itemOrder.shipcity = _objCreate.shipcity;
            itemOrder.shipregion = _objCreate.shipregion;
            itemOrder.shippostalcode = _objCreate.shippostalcode;
            itemOrder.shipcountry = _objCreate.shipcountry;

             _OrdersService.GuardarOrden(itemOrder);

            

            OrderDetails itemOrderDetail= new OrderDetails();

            itemOrderDetail.orderid = _objCreate.orderid;
            itemOrderDetail.productid = _objCreate.productid;
            itemOrderDetail.unitprice = _objCreate.unitprice;
            itemOrderDetail.qty = _objCreate.qty;
            itemOrderDetail.discount = _objCreate.discount;

            _OrdersService.GuardarOrdenDetalle(itemOrderDetail);

            return true;


        }
    }
}
