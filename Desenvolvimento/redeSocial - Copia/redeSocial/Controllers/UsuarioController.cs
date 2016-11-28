using redeSocial.Models;
using redeSocial.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redeSocial.Controllers
{
    public class UsuarioController : Controller
    {

        public ActionResult Perfil()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var usuarioDao = new UsuarioDao();
            var usuario = usuarioDao.BuscarTodosUsuarios();//carrega objeto com dados da classe

            return View(usuario);//RETORNA O HTML.. POR CONVENÇÃO ELE JÁ BUSCA NA PASTA VIEWS HOME (HOMECONTROLLER) O ARQUIVO INDEX.            
        }

        public ActionResult Login()
        {
            return View();
        }

    }
}
