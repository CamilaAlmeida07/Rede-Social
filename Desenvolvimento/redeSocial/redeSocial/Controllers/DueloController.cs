using redeSocial.Models;
using redeSocial.Models.Duelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redeSocial.Controllers
{
    public class DueloController : Controller
    {
        public ActionResult Duelo()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var dueloDao = new DueloDao();
            var duelo = dueloDao.BuscarTodosDuelos();//carrega objeto com dados da classe

            //var usuarioDao = new UsuarioDao();
            //var usuario = usuarioDao.BuscarTodosUsuarios();
            //var meuDuelo = (from d in duelo
            //                join u in usuario on d.IdCriador equals u.IdUser
            //                select u);
            //return View(meuDuelo.ToList());

            return View(duelo);
            
        }

        //ESSE CHAMA A VIEW DO INSERIR DUELO
        public ActionResult InserirDuelo()
        {
            return View();
        }

        //INSERINDO NO BANCO
        [HttpPost]
        public ActionResult InserirDuelo(Duelo duelo)
        {
            DueloDao dueloDao = new DueloDao();
            dueloDao.InserirDuelo(duelo);

            return RedirectToAction("Duelo");//return pra onde eu precisar
        }

    }
}
