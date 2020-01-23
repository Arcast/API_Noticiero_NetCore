using API_Noticiero_NetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Noticiero_NetCore
{
    public class NoticieroDbContext : DbContext
    {
        public NoticieroDbContext(DbContextOptions opciones) : base(opciones)
        {

        }

        public DbSet<Noticia> noticia { get; set; }
        public DbSet<Autor> autor { get; set; }

        protected override void OnModelCreating(ModelBuilder modeloCreador)
        {
            new Noticia.mapeo(modeloCreador.Entity<Noticia>());
            new Autor.mapeo(modeloCreador.Entity<Autor>());
        }
    }
}
