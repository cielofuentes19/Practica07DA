using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMVC01.Models;

namespace AppMVC01.Datos
{
    public class VentasAdmin
    {
        public IEnumerable<VENTAS> Consultar()
        {
            using (VENTASEntities3 contexto = new VENTASEntities3())
            {
                return contexto.VENTAS.AsNoTracking().ToList();
            }
        }
        public VENTAS Consultar(int id)
        {
            using (VENTASEntities3 contexto = new VENTASEntities3())
            {
                return contexto.VENTAS.AsNoTracking().FirstOrDefault(c =>
               c.cod_venta == id);
            }
        }
        public void Guardar(VENTAS modelo)
        {
            using (VENTASEntities3 contexto = new VENTASEntities3())
            {
                contexto.VENTAS.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(VENTAS modelo)
        {
            using (VENTASEntities3 contexto = new VENTASEntities3())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(VENTAS modelo)
        {
            using (VENTASEntities3 contexto = new VENTASEntities3())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}