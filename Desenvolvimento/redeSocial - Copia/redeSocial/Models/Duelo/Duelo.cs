using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Duelo
{
    public class Duelo
    {
        [Key]
        public int IdDuelo { get; set; }
        [Required]
        public int IdCriador { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Inicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Termino { get; set; }


        public virtual ICollection<Inscricao.Inscricao> Inscricao { get; set; } //nomes da tabela com relação
    }
}