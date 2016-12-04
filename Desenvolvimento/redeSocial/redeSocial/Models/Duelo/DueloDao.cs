using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace redeSocial.Models.Duelo
{
    public class DueloDao
    {
        //onde ficarão os metodos de gerenciamento do banco
        public IEnumerable<Duelo> BuscarTodosDuelos()
        {
            IEnumerable<Duelo> duelo;
            using (var context = new MuzokContext()) //chamando conexao
            {
                duelo = context.Duelo.ToList(); //Consulta (tolist) e passa para o objeto duelo
            }
            return duelo;
        }

        public IEnumerable<Duelo> BuscarDueloPorId(int idDuelo)
        {
            IEnumerable<Duelo> duelo;
            using (var context = new MuzokContext()) //chamando conexao
            {
                duelo = context.Duelo.Where(p => p.IdDuelo == idDuelo).ToList(); //Consulta (tolist) e passa para o objeto duelo
            }
            return duelo;
        }

        //public IEnumerable<Duelo> BuscarDuelosUsuario()
        //{
        //    IEnumerable<Duelo> duelo;
        //    IEnumerable<Models.Usuario.Usuario> usuario;
        //    using (var context = new MuzokContext()) //chamando conexao
        //    {
        //        //duelo = context.Duelo.ToList(); //Consulta (tolist) e passa para o objeto duelo

        //        var meuDuelo = (from d in duelo
        //                        join u in usuario on d.IdCriador equals u.IdUser                                
        //                         select u).ToList();
                
        //        return context.meuDuelo;
        //    }

        //    return duelo;
        //}

        public void InserirDuelo(Duelo duelo)
        {
            //esta inserindo no banco

            using (var context = new MuzokContext())
            {
                context.Duelo.Add(duelo);//add
                context.SaveChanges();//commit
            }
        }


        internal object BuscarInscricaoPorDuelo(int id)
        {
            throw new NotImplementedException();
        }
    }
}