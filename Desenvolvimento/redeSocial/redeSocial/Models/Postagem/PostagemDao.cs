using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Postagem
{
    public class PostagemDao
    {

        public IEnumerable<Postagem> BuscarTodasPostagens()
        {
            IEnumerable<Postagem> post;
            using (var context = new MuzokContext())
            {
                post = context.Postagem.ToList();
            }
            //var conexao = new MuzokContext(); //chamando conexao
            //return conexao.Usuarios.ToList();//retorna em lista
            //TO LIST É O QUE FAZ DE FATO A CONSULTA
            return post;
        }

        public void InserirPostagem(Postagem post)
        {
            //esta inserindo no banco

            using (var context = new MuzokContext())
            {
                context.Postagem.Add(post);//add
                context.SaveChanges();//commit
            }
        }
    }
}