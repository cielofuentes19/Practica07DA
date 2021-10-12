using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMVC01.Models;

namespace AppMVC01.Datos
{
    public class ProductosAdmin
    {
        public IEnumerable<PRODUCTOS> Consultar()
        {
            using (VENTASEntities2 contexto = new VENTASEntities2())
            {
                return contexto.PRODUCTOS.AsNoTracking().ToList();
            }
        }
        public PRODUCTOS Consultar(int id)
        {
            using (VENTASEntities2 contexto = new VENTASEntities2())
            {
                return contexto.PRODUCTOS.AsNoTracking().FirstOrDefault(c =>
               c.cod_producto == id);
            }
        }
        public void Guardar(PRODUCTOS modelo)
        {
            using (VENTASEntities2 contexto = new VENTASEntities2())
            {
                contexto.PRODUCTOS.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(PRODUCTOS modelo)
        {
            using (VENTASEntities2 contexto = new VENTASEntities2())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(PRODUCTOS modelo)
        {
            using (VENTASEntities2 contexto = new VENTASEntities2())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}
