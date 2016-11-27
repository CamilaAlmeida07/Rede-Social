using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace redeSocial.Models
{
    public class UsuarioDao
    {
        //onde ficarão os metodos de gerenciamento do banco
        public IEnumerable<Usuario.Usuario> BuscarTodosUsuarios()
        {
            IEnumerable<Usuario.Usuario> usuario;
            using (var context = new MuzokContext())
            {
                usuario = context.Usuario.ToList();
            }
            //var conexao = new MuzokContext(); //chamando conexao
            //return conexao.Usuarios.ToList();//retorna em lista
            //TO LIST É O QUE FAZ DE FATO A CONSULTA
            return usuario;
        }

        public void InserirUsuario(Usuario.Usuario usuario) { 
            //esta inserindo no banco
            
            using (var context = new MuzokContext())
            {
                context.Usuario.Add(usuario);//add
                context.SaveChanges();//commit
            }
        }

        
    }
}