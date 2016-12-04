using redeSocial.Models.Inscricao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redeSocial.Controllers
{
    public class InscricaoController : Controller
    {
        //
        // GET: /Inscricao/

        public ActionResult Inscricao()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var inscricaoDao = new InscricaoDao();
            var inscricao = inscricaoDao.BuscarTodasInscricoes();//carrega objeto com dados da classe

            return View(inscricao);//RETORNA O HTML.. POR CONVENÇÃO ELE JÁ BUSCA NA PASTA VIEWS HOME (HOMECONTROLLER) O ARQUIVO INDEX.            
        }

        [HttpPost]
        public ActionResult InserirInscricao(Inscricao insc)
        {
            InscricaoDao inscDao = new InscricaoDao();
            inscDao.InserirInscricao(insc);

            return RedirectToAction("Inscricao");
        }


        public ActionResult VerInscricaoDuelo(int id)
        {
            InscricaoDao inscDao = new InscricaoDao();
            var inscricao = inscDao.BuscarInscricaoPorDuelo(id);

            return View(inscricao);
        }


        public ActionResult ViewVotarDuelo(int id)
        {
            InscricaoDao inscDao = new InscricaoDao();
            var inscricao = inscDao.BuscarInscricaoPorDuelo(id);

            return View(inscricao);
        }

        public ActionResult VotarDuelo(int id)
        {
            InscricaoDao iDao = new InscricaoDao();
            iDao.IncrementarPontuacao(id);

            //CHAMA OUTRO METODO
            return RedirectToAction("Duelo", "Duelo");
        }

    }
}
