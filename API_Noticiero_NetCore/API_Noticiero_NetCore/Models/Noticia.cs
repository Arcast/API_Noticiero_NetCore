using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Noticiero_NetCore.Models
{
    public class Noticia
    {
        public int NoticiaID { get; set; }
        public String Titulo { get; set; }
        public  String Descripcion { get; set; }
        public String Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public int AutorID { get; set; }
        public Autor Autor { get; set; }

        public class mapeo
        {
            public mapeo(EntityTypeBuilder<Noticia> mapeoNoticia)
            {
                mapeoNoticia.HasKey(x => x.NoticiaID);
                mapeoNoticia.Property(x => x.Titulo).HasColumnName("Titulo");
                mapeoNoticia.Property(x => x.Descripcion).HasColumnName("Descripcion");
                mapeoNoticia.ToTable("Noticia");
                mapeoNoticia.HasOne(x => x.Autor);
            }
        }
    }
}
