using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjHotelMVC.Models
{
    public class Reserva
    {
        public QuartosDAO qd = new QuartosDAO();

        public int id { get; set; }
        public IList<Quartos> listaQuartos { get; set; }
        public DateTime dEntrada { get; set; }
        public DateTime dSaida { get; set; }
        public double valor { get; set; }
        public IList<Pessoa> pessoas { get; set; }

        public int idQuarto { get; set; }
        public int idPessoa { get; set; }
        public Pessoa p { get; set; }
        public Quartos q { get; set; }

    }
}