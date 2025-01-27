using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Codifico.WebAPI.Objects.BaseClass
{
    public class Employees
    {
        [Key]
        [Required(ErrorMessage = "El empid es obligatorio")]
        public int empid { get; set; }

        [Required(ErrorMessage = "El lastname es obligatorio")]
        [StringLength(20, ErrorMessage = "El lastname no puede superar los 15 caracteres.")]
        public string lastname { get; set; }

        [Required(ErrorMessage = "El firstname es obligatorio")]
        [StringLength(10, ErrorMessage = "El firstname no puede superar los 15 caracteres.")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "El title es obligatorio")]
        [StringLength(30, ErrorMessage = "El title no puede superar los 15 caracteres.")]
        public string title { get; set; }

        [Required(ErrorMessage = "El titleofcourtesy es obligatorio")]
        [StringLength(25, ErrorMessage = "El titleofcourtesy no puede superar los 15 caracteres.")]
        public string titleofcourtesy { get; set; }

        [Required(ErrorMessage = "El birthdate es obligatorio")]
        public DateTime birthdate { get; set; }

        [Required(ErrorMessage = "El hiredate es obligatorio")]
        public DateTime hiredate { get; set; }

        [Required(ErrorMessage = "El address es obligatorio")]
        [StringLength(60, ErrorMessage = "El address no puede superar los 15 caracteres.")]
        public string address { get; set; }

        [Required(ErrorMessage = "El city es obligatorio")]
        [StringLength(15, ErrorMessage = "El city no puede superar los 15 caracteres.")]
        public string city { get; set; }


        [StringLength(15, ErrorMessage = "El region no puede superar los 15 caracteres.")]
        public string? region { get; set; }


        [StringLength(10, ErrorMessage = "El postalcode no puede superar los 15 caracteres.")]
        public string? postalcode { get; set; }

        [Required(ErrorMessage = "El country es obligatorio")]
        [StringLength(15, ErrorMessage = "El country no puede superar los 15 caracteres.")]
        public string country { get; set; }


        [Required(ErrorMessage = "El phone es obligatorio")]
        [StringLength(24, ErrorMessage = "El phone no puede superar los 15 caracteres.")]
        public string phone { get; set; }

        [ForeignKey("EMPID")]
        public int? mgrid { get; set; }

    }
}
