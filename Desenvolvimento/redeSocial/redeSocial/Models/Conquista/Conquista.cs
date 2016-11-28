using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Conquista
{
    public class Conquista
    {
        [Key]
        public int IdUser { get; set; }
    }
}