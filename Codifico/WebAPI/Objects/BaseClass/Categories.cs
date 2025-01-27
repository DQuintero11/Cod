using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codifico.WebAPI.Objects.BaseClass
{
    [Table("Categories", Schema = "Production")]
    public class Categories
    {
        [Key]
        public int categoryid { get; set; }

        [Required(ErrorMessage = "El categoryname es obligatorio")]
        [StringLength(15, ErrorMessage = "El categoryname no puede superar los 15 caracteres.")]
        public string categoryname { get; set; }


        [Required(ErrorMessage = "El description es obligatorio")]
        [StringLength(200, ErrorMessage = "El description no puede superar los 200 caracteres.")]
        public string description { get; set; }
    }
}
