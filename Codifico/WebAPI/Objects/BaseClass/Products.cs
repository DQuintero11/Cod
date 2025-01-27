using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace Codifico.WebAPI.Objects.BaseClass
{
    [Table("Products", Schema = "Production")]
    public class Products
    {

        [Key]
        public int productid { get; set; }

        [Required(ErrorMessage = "El productname es obligatorio")]
        [StringLength(20, ErrorMessage = "El productname no puede superar los 15 caracteres.")]
        public string productname { get; set; }

        [ForeignKey("SUPPLIERS")]
        [Required(ErrorMessage = "El supplierid es obligatorio")]
        public int supplierid { get; set; }

        [ForeignKey("CATEGORIES")]
        [Required(ErrorMessage = "El categoryid es obligatorio")]
        public int categoryid { get; set; }

        [Required(ErrorMessage = "El unitprice es obligatorio")]
        public decimal unitprice { get; set; }

        [Required(ErrorMessage = "El discontinued es obligatorio")]
        public bool discontinued { get; set; }

    }
}
