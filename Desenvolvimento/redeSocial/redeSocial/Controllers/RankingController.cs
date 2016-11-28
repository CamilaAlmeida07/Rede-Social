using redeSocial.Models.Ranking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redeSocial.Controllers
{
    public class RankingController : Controller
    {
        //
        // GET: /Ranking/

        public ActionResult Ranking()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var rankDao = new RankingDao();
            var rank = rankDao.BuscarTodosRankings();//carrega objeto com dados da classe

            return View(rank);//RETORNA O HTML.. POR CONVENÇÃO ELE JÁ BUSCA NA PASTA VIEWS HOME (HOMECONTROLLER) O ARQUIVO INDEX.
            
        }

    }
}
