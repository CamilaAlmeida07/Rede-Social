using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace redeSocial.Models.Conquista
{
    public class ConquistaDao
    {
        //onde ficarão os metodos de gerenciamento do banco
        public IEnumerable<Conquista> BuscarTodasConquistas()
        {
            IEnumerable<Conquista> conquista;
            using (var context = new MuzokContext()) //chamando conexao
            {
                conquista = context.Conquista.ToList();
            }
            return conquista;
        }

        public void InserirConquista(Conquista conquista)
        {
            using (var context = new MuzokContext())
            {
                context.Conquista.Add(conquista);//add
                context.SaveChanges();//commit
            }
        }
    }
}