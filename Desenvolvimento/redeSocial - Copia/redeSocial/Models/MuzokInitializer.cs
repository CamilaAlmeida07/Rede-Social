using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace redeSocial.Models
{
    //dropcreatedatabasealways
    public class MuzokInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MuzokContext>
    {
        protected override void Seed(MuzokContext context)
        {
            //esta inserindo no banco
            context.Usuario.Add(new Usuario.Usuario 
            {
                Nome = "Meu nome",
                Senha = "Minha senha"
            });

            context.SaveChanges();//commit

        }
    }
}