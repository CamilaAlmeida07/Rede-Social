using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Ranking
{
    public class RankingDao
    {
        //onde ficarão os metodos de gerenciamento do banco
        public IEnumerable<Ranking> BuscarTodosRankings()
        {
            IEnumerable<Ranking> rank;
            using (var context = new MuzokContext()) //chamando conexao
            {
                rank = context.Ranking.OrderByDescending(s => s.Pontos).ToList(); 
            }
            return rank;
        }

        public void InserirRanking(Ranking rank)
        {
            using (var context = new MuzokContext())
            {
                context.Ranking.Add(rank);//add
                context.SaveChanges();//commit
            }
        }
    }
}