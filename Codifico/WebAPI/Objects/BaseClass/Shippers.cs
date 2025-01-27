using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Security.Principal;

namespace Codifico.WebAPI.Objects.BaseClass
{
    [Table("Shippers", Schema = "Sales")]
    public class Shippers
    {


        [Key]
        public int shipperid { get; set; }

        [Required(ErrorMessage = "El companyname es obligatorio")]
        [StringLength(40, ErrorMessage = "El companyname no puede superar los 15 caracteres.")]
        public string companyname { get; set; }

        [Required(ErrorMessage = "El phone es obligatorio")]
        [StringLength(24, ErrorMessage = "El phone no puede superar los 15 caracteres.")]
        public string phone { get; set; }

    }
}


