using prjHotelMVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjHotelMVC.Controllers
{
    public class HomeController : Controller
    {
        QuartosDAO sc = new QuartosDAO();
        PessoasDAO ps = new PessoasDAO();
        ReservaDAO rs = new ReservaDAO();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            return View();
        }
        #region Quartos
        //AQUI começa os actions dos QUARTOS
        public ActionResult List()
        {
            return View("ListQuarto", sc.Listar());
        }

        public ActionResult Adicionar()
        {
            return View("AdicionarQuarto");
        }

        [HttpPost]
        public ActionResult Adicionar(Quartos d)
        {
            sc.Adicionar(d);
            return View("ListQuarto", sc.Listar());
        }

        public ActionResult Apagar(int id)
        {
            sc.Apagar(id);
            return View("ListQuarto", sc.Listar());
        }

        #endregion

        #region Pessoas

        public ActionResult ListPessoas()
        {
            return View("ListPessoas", ps.Listar());
        }

        public ActionResult AdicionarPessoas()
        {
            return View("AdicionarPessoas");
        }

        [HttpPost]
        public ActionResult AdicionarPessoas(Pessoa d)
        {
            ps.Adicionar(d);
            return View("ListPessoas", ps.Listar());
        }

        public ActionResult ApagarPessoas(int id)
        {
            ps.Apagar(id);
            return View("ListPessoas", ps.Listar());
        }

        #endregion


        #region Reservas


        public ActionResult ListReservas()
        {
            return View("ListReservas", rs.Listar());
        }

        public ActionResult AdicionarReserva()
        {
            var res = new Reserva();
            res.listaQuartos = sc.Listar();
            res.pessoas = ps.Listar();

            return View("AdicionarReserva", res);
        }

        [HttpPost]
        public ActionResult AdicionarReserva(Reserva d)
        {
            Pessoa p = ps.Pesquisar(d.idPessoa);
            Quartos q = sc.Pesquisar(d.idQuarto);

            if (p != null && q != null)
            {
                d.p = p;
                d.q = q;
                d.valor = rs.CalculaValor(d);
                rs.Adicionar(d);
                return View("ListReservas", rs.Listar());
            } else
            {
                return View("Error");
            }
        }
        #endregion
    }
}