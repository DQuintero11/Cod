using Codifico.WebAPI.DataBase;
using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Codifico.WebAPI.Objects.Request;
using Microsoft.EntityFrameworkCore;

namespace Codifico.WebAPI.Repository.Persistency
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly AppDbContext _context;


        public OrdersRepository(AppDbContext context)
        {
            _context = context;
        }


        public List<OrdersView> FilterOrdersByCustomers(RequestOrders _objRequestOrderByCustomer)
        {
            var lista = _context.OrdersView.FromSqlRaw("EXEC OrdersView {0}" , _objRequestOrderByCustomer.idCustomer).ToList();
            return lista;
        }

        public List<OrdersPrediction> OrderPrediction()
        {
            var lista = new List<OrdersPrediction>();

            lista = _context.OrdersPredictions.FromSqlRaw("EXEC OrdersPrediction").ToList();

            return lista;
        }


        public void GuardarOrden(Orders itemOrder)
        {
            _context.Orders.Add(itemOrder);

            _context.SaveChanges();

        }

        public void GuardarOrdenDetalle(OrderDetails itemOrderDetail)
        {
             var x = _context.Orders.OrderByDescending(X => X.orderid).Select(y => y.orderid).FirstOrDefault();

            itemOrderDetail.orderid = x;

            _context.OrderDetails.Add(itemOrderDetail);

            _context.SaveChanges();
        }

    }
}
