using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Postagem
{
    public class PostagemDao
    {
        //RETORNA OBJ DO TIPO POSTAGEM
        public IEnumerable<Postagem> BuscarTodasPostagens()
        {
            //INSTANCIA DO OBJETO, COM APELIDO POST
            IEnumerable<Postagem> post;

            //ESTOU USANDO O CONTEXTO XPTO
            using (var context = new MuzokContext())
            {
                post = context.Postagem.OrderByDescending(p => p.IdPostagem).ToList();
            }
            
            return post;
        }

        public IEnumerable<Postagem> BuscarPorPostagem(int idPost)
        {
            IEnumerable<Postagem> post;
            using (var context = new MuzokContext())
            {
                post = context.Postagem.Where(p => p.IdPostagem == idPost).ToList();
            }

            return post;
        }

        public IEnumerable<Postagem> BuscaPorUsuario(int id)
        {
            IEnumerable<Postagem> post;
            using (var context = new MuzokContext())
            {
                post = context.Postagem.Where(p => p.IdUser == id).OrderByDescending(p => p.Data).ToList();
            }

            return post;
        }

        //public IEnumerable<Compost> BuscarComposto()
        //{
        //    IEnumerable<Compost> comp;
        //    using (var context = new MuzokContext())
        //    {
        //        var composto = context.Usuario
        //        .Join(context.Postagem, usuario => usuario.IdUser, postagem => postagem.IdUser, (usuario, postagem) => new { usuario, postagem })
        //        .Select(x => new
        //        {
        //            x.postagem.IdPostagem,
        //            x.postagem.IdUser,
        //            x.usuario.Nome,
        //            x.postagem.Conteudo,
        //            x.postagem.Data,
        //            x.postagem.Curtidas
        //        }).ToList();

        //        comp = composto;

        //        return comp;
        //    }
        //}

        public void InserirPostagem(Postagem post)
        {
            using (var context = new MuzokContext())
            {
                context.Postagem.Add(post);//add
                context.SaveChanges();//commit
            }
        }

       
        internal void IncrementarCurtidas(int id)
        {
            
           
            using (var context = new MuzokContext())
            {
                var curtidas = context.Postagem.SingleOrDefault(p => p.IdPostagem == id);
                curtidas.Curtidas++;
                context.SaveChanges();                
                //context.Postagem.Attach(post);
                //context.Entry(post).Property(x => x.IdPostagem).IsModified = true;
                //context.Entry(post).State = EntityState.Modified;
                
            }
        }

        
    }
}