using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Codifico.WebAPI.Objects.BaseClass
{
    [Table("Orders", Schema = "Sales")]
    public class Orders
    {

        [Key]
        public int orderid { get; set; }

        [ForeignKey("Customers")]
        public int custid { get; set; }

        [ForeignKey("Employees")]
        [Required(ErrorMessage = "El empid es obligatorio")]
        public int empid { get; set; }

        [Required(ErrorMessage = "El orderdate es obligatorio")]
        public DateTime orderdate { get; set; }

        [Required(ErrorMessage = "El requireddate es obligatorio")]
        public DateTime requireddate { get; set; }


        public DateTime shippeddate { get; set; }

        [ForeignKey("Shippers")]
        [Required(ErrorMessage = "El shipperid es obligatorio")]
        public int shipperid { get; set; }

        [Required(ErrorMessage = "El freight es obligatorio")]
        public decimal freight { get; set; }


        [Required(ErrorMessage = "El shipname es obligatorio")]
        [StringLength(40, ErrorMessage = "El shipname no puede superar los 15 caracteres.")]
        public string shipname { get; set; }

        [Required(ErrorMessage = "El shipaddress es obligatorio")]
        [StringLength(60, ErrorMessage = "El shipaddress no puede superar los 15 caracteres.")]
        public string shipaddress { get; set; }

        [Required(ErrorMessage = "El shipcity es obligatorio")]
        [StringLength(15, ErrorMessage = "El shipcity no puede superar los 15 caracteres.")]
        public string shipcity { get; set; }


        [StringLength(15, ErrorMessage = "El shipregion no puede superar los 15 caracteres.")]
        public string shipregion { get; set; }


        [StringLength(10, ErrorMessage = "El shippostalcode no puede superar los 15 caracteres.")]
        public string shippostalcode { get; set; }


        [Required(ErrorMessage = "El shipcountry es obligatorio")]
        [StringLength(15, ErrorMessage = "El shipcountry no puede superar los 15 caracteres.")]
        public string shipcountry { get; set; }
    }
}


