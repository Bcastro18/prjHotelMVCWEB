using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prjHotelMVC.Models
{
    public class Pessoa
    {
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string endereco { get; set; }
        [Required]
        public string cidade { get; set; }
        [Required]
        public string estado { get; set; }
        [Required]
        public string pais { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string telefone { get; set; }
        [Required]
        public string celular { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string CEP { get; set; }
        [Required]
        public string RG { get; set; }
        [Required]
        public DateTime dataNasc { get; set; }

    }
}