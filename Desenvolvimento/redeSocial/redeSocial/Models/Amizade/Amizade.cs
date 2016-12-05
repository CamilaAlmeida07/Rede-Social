using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Amizade
{
    public class Amizade
    {
        [Key]
        public int IdAmizade { get; set; }
        [Required]
        public int IdUserA { get; set; }
        [Required]
        public int IdUserB { get; set; }
        [Required]
        [DataType(DataType.Date)]//SÓ DATE, SEM O TIME
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]//FORMATO DD/MM/AAAA
        public DateTime Inicio { get; set; }
    }
}