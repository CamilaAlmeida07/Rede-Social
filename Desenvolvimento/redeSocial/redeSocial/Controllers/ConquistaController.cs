using redeSocial.Models.Conquista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redeSocial.Controllers
{
    public class ConquistaController : Controller
    {

        public ActionResult Conquista()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var conquistaDao = new ConquistaDao();
            var conquista = conquistaDao.BuscarTodasConquistas();//carrega objeto com dados da classe

            return View(conquista);//RETORNA O HTML.. POR CONVENÇÃO ELE JÁ BUSCA NA PASTA VIEWS HOME (HOMECONTROLLER) O ARQUIVO INDEX.            
        }

    }
}
