using System;
using Microsoft.EntityFrameworkCore;
using Accidentes_Console.models;

namespace Accidentes_Console
{
    public class InfraccionContext: DbContext
    {
        public DbSet<Infraccion> Infracciones {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder OptionA){
            if (!OptionA.IsConfigured){
                OptionA.UseSqlite("Data Source=Infraccion.db");
            }
        }
    }
}