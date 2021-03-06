﻿using System;
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
            
            return post;
        }

        public IEnumerable<Postagem> BuscaPorUsuario(int id)
        {
            IEnumerable<Postagem> post;
            using (var context = new MuzokContext())
            {
                post = context.Postagem.Where(p => p.IdUser == id).ToList();
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
            //esta inserindo no banco

            using (var context = new MuzokContext())
            {
                context.Postagem.Add(post);//add
                context.SaveChanges();//commit
            }
        }
    }
}