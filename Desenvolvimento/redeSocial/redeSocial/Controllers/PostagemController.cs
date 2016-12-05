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
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

           

            //INSTANCIA DA CLASSE DAO - GERENCIA A TABELA POSTAGEM
            var postDao = new PostagemDao();
            var post = postDao.BuscarTodasPostagens();//carrega objeto com dados da classe

            //DECLARANDO ARRAY VAZIO
            string[] nomeArray = new string[200];
            string[] fotoArray = new string[200];
          

            int i = 0;
            foreach (var item in post)
            {
                var usuDao = new UsuarioDao();
                var usu = usuDao.BuscarUsuarioPorId(item.IdUser);//carrega objeto com dados da classe
                
                foreach(var reg in usu)
                {
                    nomeArray[i] = reg.Nome;
                    fotoArray[i] = reg.Foto;
                }
                i++;
            }
            

            //VIEWBAG RECEBE ARRAY
            ViewBag.UsuNome = nomeArray;
            ViewBag.UsuFoto = fotoArray;

            return View(post);//RETORNA O HTML.. POR CONVENÇÃO ELE JÁ BUSCA NA PASTA VIEWS HOME (HOMECONTROLLER) O ARQUIVO INDEX.
        }

        public ActionResult InserirPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InserirPost(Postagem post)
        {
            post.IdUser = 1;
            post.Curtidas = 0;
            post.Data = DateTime.Today.Date;
            
            PostagemDao postDao = new PostagemDao();
            postDao.InserirPostagem(post);      
           
            return RedirectToAction("Index");
        }


        public ActionResult CurtirPost(int id)
        {  
            PostagemDao pDao = new PostagemDao();
            pDao.IncrementarCurtidas(id);

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult CurtirPost(Postagem post)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        post.Curtidas++;

        //        PostagemDao postDao = new PostagemDao();
        //        postDao.IncrementarCurtidas(post);            
        //    }

        //    return RedirectToAction("Index");
        //}

  
        

        //public string nomeUsuario(int idUser)
        //{
        //    UsuarioDao usuDao = new UsuarioDao();
        //    IEnumerable<Usuario> usu;
        //    usu = usuDao.BuscarPorId(idUser);
        //    return ;
        //}
               

        //public ActionResult Index()
        //{

        //    var usuarioDao = new UsuarioDao();
        //    var usuario = usuarioDao.BuscarPorId(1);

        //    var postagemDao = new PostagemDao();
        //    var postagem = postagemDao.BuscaPorUsuario(1);


        //    ViewModel viewModel = new ViewModel(usuario, postagem);

        //    return View(viewModel);
        //}


    }
}
