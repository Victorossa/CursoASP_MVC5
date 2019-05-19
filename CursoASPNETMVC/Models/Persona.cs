using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoASPNETMVC.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campol {0} es Obligatorio ponerlo")]
        public string Nombre { get; set; }
        [StringLength(6, MinimumLength = 5, ErrorMessage = "El campo {0} debe tener una longitud minima de {2} y una longitud maxima de {1}")]
        public string CodigoPostal { get; set; }
        [Range(18, 100, ErrorMessage = "El campo {0} debe ser un numero entre {1} y {2}")]
        public int Edad { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [NotMapped]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Los Emails no concuerdan")]
        public string ConfirmarEmail { get; set; }
        [CreditCard(ErrorMessage = "Tarjeta de Credito Invalida")]
        public string TarjetaDeCredito { get; set; }
        [Remote("DivisibleEntre2", "Personas",ErrorMessage = "El número debe ser divisible entre 2")]
        public int NumeroDivisibleEntre2 { get; set; }




    }
}