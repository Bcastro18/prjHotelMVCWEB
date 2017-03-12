using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prjHotelMVC.Models
{
    public class Quartos
    {
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        public int tipo { get; set; }
        public string desc { get; set; }
        public int quantHospedes { get; set; }


    }
}