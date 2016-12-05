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
            Usuario usuario;
            try
            {
                usuario = usuarioDao.BuscarUsuarioPorId(Convert.ToInt32(Session["IdUser"].ToString())).FirstOrDefault();//usuarioDao.BuscarTodosUsuarios();//carrega objeto com dados da classe
            }
            catch (Exception)
            {
                return RedirectToAction("Login");
            }
            

            return View(usuario);//RETORNA O HTML.. POR CONVENÇÃO ELE JÁ BUSCA NA PASTA VIEWS HOME (HOMECONTROLLER) O ARQUIVO INDEX.            
        }

        public ActionResult Login()
        {
            if (!(Session["IdUser"] == null))
            {
                return RedirectToAction("Index", "Postagem");
            }
            return View();
        }

        [HttpPost]
        public ActionResult LoginRequest(Usuario user)
        {
            UsuarioDao usuarioDao = new UsuarioDao();

            Usuario usuario = usuarioDao.Login(user);

            if (usuario != null)
            {
                Session["IdUser"] = usuario.IdUser;
                return RedirectToAction("Index", "Postagem");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session["IdUser"] = null;

            return RedirectToAction("Login");
        }

    }
}
