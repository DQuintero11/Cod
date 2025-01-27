using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Codifico.WebAPI.Objects.Extends
{
    public class OrdersView
    {

        public int orderid { get; set; }

        public DateTime requireddate { get; set; }

        public DateTime shippeddate { get; set; }

        public string shipname { get; set; }

        public string shipaddress { get; set; }

        public string shipcity { get; set; }

        public int custid { get; set; }

    }
}
