using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Inscricao
{
    public class InscricaoDao
    {
        public IEnumerable<Inscricao> BuscarTodasInscricoes()
        {
            IEnumerable<Inscricao> inscricao;
            using (var context = new MuzokContext())
            {
                inscricao = context.Inscricao.ToList();
            }

            return inscricao;
        }

        public void InserirInscricao(Inscricao inscricao)
        {
            //esta inserindo no banco

            using (var context = new MuzokContext())
            {
                context.Inscricao.Add(inscricao);//add
                context.SaveChanges();//commit
            }
        }
    }
}