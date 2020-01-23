using API_Noticiero_NetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Noticiero_NetCore.Servicios
{
    public class NoticiaService
    {
        private readonly NoticieroDbContext _NoticieroDbContext;
        public NoticiaService(NoticieroDbContext noticieroDbContext)
        {
            _NoticieroDbContext = noticieroDbContext;
        }

        public List<Noticia> ListarNoticias()
        {
            var resultado = _NoticieroDbContext.noticia.Include(x => x.Autor).ToList();
            return resultado;
        }

        public Boolean AgregarNoticia(Noticia _noticia)
        {
            try
            {
                _NoticieroDbContext.noticia.Add(_noticia);
                _NoticieroDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean EditarNoticia(Noticia _noticia)
        {
            try
            {
                _NoticieroDbContext.Entry(_noticia).State = EntityState.Modified;
                _NoticieroDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean EliminarNoticia(int _NoticiaId)
        {
            try
            {
                var _Noticia = _NoticieroDbContext.noticia.Find(_NoticiaId);
                _NoticieroDbContext.Entry(_Noticia).State = EntityState.Deleted;
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
