using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Votos
{
    public class Votos
    {
        //CODE FIRST - 
        [Key]//CHAVE PRIMARIA
        public int IdVoto { get; set; }
        [Required]//NOT NULL
        public int IdUser { get; set; }
        [Required]//NOT NULL
        public int IdDuelo { get; set; }
        [Required]
        [DataType(DataType.Date)]//SÓ DATE, SEM O TIME
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]//FORMATO DD/MM/AAAA
        public DateTime Data { get; set; }
    }
}