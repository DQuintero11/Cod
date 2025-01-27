using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Codifico.WebAPI.Objects.BaseClass
{
    [Table("OrderDetails", Schema = "Sales")]
    public class OrderDetails
    {

        [Required(ErrorMessage = "El orderid es obligatorio")]
        public int orderid { get; set; }

        [Required(ErrorMessage = "El productid es obligatorio")]
        public int productid { get; set; }

        [Required(ErrorMessage = "El productid es obligatorio")]
        public decimal unitprice { get; set; }

        [Required(ErrorMessage = "El productid es obligatorio")]
        public short qty { get; set; }

        [Required(ErrorMessage = "El discount es obligatorio")]
        public decimal discount { get; set; }
    }
}
