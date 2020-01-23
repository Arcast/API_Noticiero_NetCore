using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Noticiero_NetCore.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        public class mapeo
        {
            public mapeo(EntityTypeBuilder<Autor> mapeoAutor)
            {
                mapeoAutor.HasKey(x => x.AutorId);
                mapeoAutor.Property(x => x.Nombre).HasColumnName("Nombre");
                mapeoAutor.Property(x => x.Apellido).HasColumnName("Apellido");
                mapeoAutor.ToTable("Autor");
               
            }
        }
    }
}
