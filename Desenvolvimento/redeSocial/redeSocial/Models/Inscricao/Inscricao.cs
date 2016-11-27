using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Inscricao
{
    public class Inscricao
    {
        [Key]
        public int IdInscricao { get; set; }
        [Required]
        public int IdDuelo { get; set; }
        [Required]
        public int IdUser { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        [Required]
        public int Pontuacao { get; set; }

    }
}