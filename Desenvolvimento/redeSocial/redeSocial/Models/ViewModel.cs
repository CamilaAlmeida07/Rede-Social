using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace redeSocial.Models
{
    public class ViewModel
    {
        private IEnumerable<Usuario.Usuario> usuario;
        private IEnumerable<Postagem.Postagem> postagem;


        public ViewModel(Usuario.Usuario usu, Postagem.Postagem post)
        {
            Usuario = usu;
            Postagem = post;
        }

        public ViewModel(IEnumerable<Usuario.Usuario> usuario, IEnumerable<Postagem.Postagem> postagem)
        {
            // TODO: Complete member initialization
            this.usuario = usuario;
            this.postagem = postagem;
        }

        public Usuario.Usuario Usuario { get; private set; }
        public Postagem.Postagem Postagem { get; private set; }
    }
}