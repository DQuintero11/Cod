using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Numerics;
using System.Security.Principal;

namespace Codifico.WebAPI.Objects.BaseClass
{

    [Table("Customers", Schema = "Sales")]
    public class Customers
    {
        [Key]
        public int custid { get; set; }

        [Required(ErrorMessage = "El companyname es obligatorio")]
        [StringLength(40, ErrorMessage = "El companyname no puede superar los 15 caracteres.")]
        public string companyname { get; set; }

        [Required(ErrorMessage = "El contactname es obligatorio")]
        [StringLength(30, ErrorMessage = "El contactname no puede superar los 15 caracteres.")]
        public string contactname { get; set; }

        [Required(ErrorMessage = "El contacttitle es obligatorio")]
        [StringLength(30, ErrorMessage = "El contacttitle no puede superar los 15 caracteres.")]
        public string contacttitle { get; set; }

        [Required(ErrorMessage = "El address es obligatorio")]
        [StringLength(60, ErrorMessage = "El address no puede superar los 15 caracteres.")]
        public string address { get; set; }

        [Required(ErrorMessage = "El city es obligatorio")]
        [StringLength(15, ErrorMessage = "El city no puede superar los 15 caracteres.")]
        public string city { get; set; }

        [Required(ErrorMessage = "El region es obligatorio")]
        [StringLength(15, ErrorMessage = "El region no puede superar los 15 caracteres.")]
        public string region { get; set; }

        [Required(ErrorMessage = "El postalcode es obligatorio")]
        [StringLength(10, ErrorMessage = "El postalcode no puede superar los 15 caracteres.")]
        public string postalcode { get; set; }

        [Required(ErrorMessage = "El country es obligatorio")]
        [StringLength(15, ErrorMessage = "El country no puede superar los 15 caracteres.")]
        public string country { get; set; }

        [Required(ErrorMessage = "El phone es obligatorio")]
        [StringLength(24, ErrorMessage = "El phone no puede superar los 15 caracteres.")]
        public string phone { get; set; }

        [Required(ErrorMessage = "El fax es obligatorio")]
        [StringLength(24, ErrorMessage = "El fax no puede superar los 15 caracteres.")]
        public string fax { get; set; }

    }
}





