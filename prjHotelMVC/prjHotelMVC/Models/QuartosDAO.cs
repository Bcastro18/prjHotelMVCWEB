using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjHotelMVC.Models
{
    public class QuartosDAO
    {

        public static List<Quartos> qs = new List<Quartos>();

        public List<Quartos> Listar()
        {

            return qs;
        }

        public void Adicionar(Quartos d)
        {
            qs.Add(d);

        }

        public Quartos Pesquisar(int id)
        {
            Quartos d1;
            d1 = qs.Find(x => x.id == id);

            return d1;
        }

        public void Apagar(int id)
        {
            Quartos d1 = Pesquisar(id);
            qs.Remove(d1);

        }
    }
}