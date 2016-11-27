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
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            //código de acesso ao banco
            using (var context = new MuzokContext())
            {
                context.Duelo.ToList();
            }

            var dueloDao = new DueloDao();
            var duelo = dueloDao.BuscarTodosDuelos();//carrega objeto com dados da classe
            return View(duelo);//RETORNA O HTML.. POR CONVENÇÃO ELE JÁ BUSCA NA PASTA VIEWS HOME (HOMECONTROLLER) O ARQUIVO INDEX.
            
        }

    }
}
