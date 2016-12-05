﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Curtida
{
    public class Curtida
    {
        [Key]
        public int IdCurtida { get; set; }
        [Required]
        public int IdUser { get; set; }
        [Required]
        public int IdPostagem { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Inicio { get; set; }
    }
}