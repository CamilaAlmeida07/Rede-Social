using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace redeSocial.Models
{
    public class MuzokContext : DbContext //proprio do entity framekwork
    {
        //CRIAÇÃO DOS MODELOS NO BANCO DE DADOS
        public DbSet<Conquista.Conquista> Conquista { get; set; }  
        public DbSet<Duelo.Duelo> Duelo { get; set; }
        public DbSet<Inscricao.Inscricao> Inscricao { get; set; }
        public DbSet<Postagem.Postagem> Postagem { get; set; }
        public DbSet<Usuario.Usuario> Usuario { get; set; }
        public DbSet<Ranking.Ranking> Ranking { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //evita q gera nomes no plural
        }
    }
}