using Codifico.WebAPI.Interfaces.Business;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Codifico.WebAPI.Objects.Request;

namespace Codifico.WebAPI.Repository
{
    public interface IOrdersRepository
    {
        List<OrdersView> FilterOrdersByCustomers(RequestOrders _objRequestOrderByCustomer);
        List<OrdersPrediction> OrderPrediction();
        void GuardarOrden(Orders itemOrder);
        void GuardarOrdenDetalle(OrderDetails itemOrderDetail);

    }
}
