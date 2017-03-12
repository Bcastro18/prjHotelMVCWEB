using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjHotelMVC.Models
{
    public class ReservaDAO
    {

        public static List<Reserva> rs = new List<Reserva>();

        public List<Reserva> Listar()
        {

            return rs;
        }

        public void Adicionar(Reserva d)
        {
            rs.Add(d);

        }

        public Reserva Pesquisar(int id)
        {
            Reserva d1;
            d1 = rs.Find(x => x.id == id);

            return d1;
        }

        public void Apagar(int id)
        {
            Reserva d1 = Pesquisar(id);
            rs.Remove(d1);

        }

        public double CalculaValor(Reserva r)
        {
            double diaria = 100;
            var s = r.dSaida;
            var e = r.dEntrada;
            double valor = 0;

            if (s.Year == e.Year)
            {
                if(s.Month == e.Month)
                {
                    if(s.Day > e.Day)
                    {
                        valor = (s.Day - e.Day) * diaria;
                    } else if (s.Day == e.Day)
                    {
                        valor = diaria;
                    } else
                    {
                        valor = -1;
                    }
                } else if(s.Month > e.Month)
                {
                    var i = s - e;
                    valor = i.Days * 100;

                } else
                {
                    valor = -1;
                }

            }
            else if (s.Year > e.Year)
            {
                var i = s - e;
                valor = i.Days * diaria;
            }
            else
            {
                valor = -1;
            }

            return valor;
        }

    }
}