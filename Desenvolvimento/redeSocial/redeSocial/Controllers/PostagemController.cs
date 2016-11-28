using redeSocial.Models;
using redeSocial.Models.Postagem;
using redeSocial.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redeSocial.Controllers
{
    public class PostagemController : Controller
    {
        public ActionResult Index(string submit)
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var postDao = new PostagemDao();
            var post = postDao.BuscarTodasPostagens();//carrega objeto com dados da classe

            return View(post);//RETORNA O HTML.. POR CONVENÇÃO ELE JÁ BUSCA NA PASTA VIEWS HOME (HOMECONTROLLER) O ARQUIVO INDEX.
        }

        [HttpPost]
       

        //public ActionResult Index()
        //{

        //    var usuarioDao = new UsuarioDao();
        //    var usuario = usuarioDao.BuscarPorId(1);

        //    var postagemDao = new PostagemDao();
        //    var postagem = postagemDao.BuscaPorUsuario(1);


        //    ViewModel viewModel = new ViewModel(usuario, postagem);

        //    return View(viewModel);
        //}

        
        [HttpPost]
        public ActionResult Novo()
        {
            ViewData["btnSubmit"] = "TESTE";
            return View("Index");

        }

        [HttpPost]
        public ActionResult CreatePost(Postagem post)
        {
            PostagemDao postDao = new PostagemDao();
            postDao.InserirPostagem(post);

            return RedirectToAction("Index");//return pra onde eu precisar
        }


    }
}
