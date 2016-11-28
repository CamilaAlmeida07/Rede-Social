using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Postagem
{
    public class Postagem
    {
        [Key]
        public int IdPostagem { get; set; }
        [Required]
        public int IdUser { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        [Required]
        public int Curtidas { get; set; }
        [Required]
        public string Conteudo { get; set; }



        //METÓDO DS GETS E SETS, OU SEJA, DE DEFINIÇÕES
        //OS DADOS DAQUI SÃO USADOS PARA GERAR O BANCO

    }
}