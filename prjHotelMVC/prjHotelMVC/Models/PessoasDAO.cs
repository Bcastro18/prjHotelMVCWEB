using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjHotelMVC.Models
{
    public class PessoasDAO
    {
        public static List<Pessoa> qs = new List<Pessoa>();

        public List<Pessoa> Listar()
        {

            return qs;
        }

        public void Adicionar(Pessoa d)
        {
            qs.Add(d);

        }

        public Pessoa Pesquisar(int id)
        {
            Pessoa d1;
            d1 = qs.Find(x => x.id == id);

            if (d1 != null)
                return d1;
            else
                return null;
        }

        public void Apagar(int id)
        {
            Pessoa d1 = Pesquisar(id);
            qs.Remove(d1);

        }

    }
}