using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Ranking
{
    public class Ranking
    {

        [Key]
        public int IdRanking { get; set; }
        [Required]
        public int Pontos { get; set; }
        [Required]
        public int Vitorias { get; set; }
        [Required]
        public int Duelos { get; set; }
        [Required]
        public int idUser{ get; set; }

        //METÓDO DS GETS E SETS, OU SEJA, DE DEFINIÇÕES
        //OS DADOS DAQUI SÃO USADOS PARA GERAR O BANCO
    }
}