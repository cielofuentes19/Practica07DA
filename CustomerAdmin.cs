using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMVC01.Models;

namespace AppMVC01.Datos
{
    public class CustomerAdmin
    {
        public IEnumerable<CUSTOMERS> Consultar()
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.CUSTOMERS.AsNoTracking().ToList();
            }
        }
        public CUSTOMERS Consultar(int id)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.CUSTOMERS.AsNoTracking().FirstOrDefault(c =>
               c.codigo == id);
            }
        }
        public void Guardar(CUSTOMERS modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.CUSTOMERS.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(CUSTOMERS modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(CUSTOMERS modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}