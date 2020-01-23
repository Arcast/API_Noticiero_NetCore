using API_Noticiero_NetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Noticiero_NetCore.Servicios
{
    public class AutorService
    {
        private readonly NoticieroDbContext _NoticieroDbContext;

        public AutorService(NoticieroDbContext noticieroDbContext)
        {
            _NoticieroDbContext = noticieroDbContext;
        }
        public List<Autor> ListarAutores()
        {
            var resultado = _NoticieroDbContext.autor.ToList();
            return resultado;
        }

        public Boolean AgregarAutor(Autor _autor)
        {
            try
            {
                _NoticieroDbContext.autor.Add(_autor);
                _NoticieroDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean EditarAutor(Autor _autor)
        {
            try
            {
                _NoticieroDbContext.Entry(_autor).State = EntityState.Modified;
                _NoticieroDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean EliminarAutor(Autor _autor)
        {
            try
            {
                _NoticieroDbContext.Entry(_autor).State = EntityState.Deleted;
                _NoticieroDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
