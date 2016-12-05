using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace redeSocial.Models.Usuario
{
    public class Usuario
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Foto { get; set; }


        //ENTIDADES QUE RECEBERAO O IDUSER COMO FK
        public virtual ICollection<Postagem.Postagem> Postagem { get; set; }
        public virtual ICollection<Ranking.Ranking> Ranking { get; set; }
        public virtual ICollection<Inscricao.Inscricao> Inscricao { get; set; }
        public virtual ICollection<Votos.Votos> Votos { get; set; }


        public object IdCriador { get; set; }
    }
}