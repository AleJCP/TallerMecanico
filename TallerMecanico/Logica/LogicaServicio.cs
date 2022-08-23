using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;

namespace TallerMecanico.Logica
{
    class LogicaServicio
    {
        public ICollection<Servicio> ListarServicios()
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from c in context.Servicios
                          select c;
                return lst.ToList();
            }
        }
        public int ContarServicios()
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from c in context.Servicios
                          select c;
                return lst.ToList().Count;
            }
        }
        public bool AddServicio(Servicio servicio)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    context.Servicios.Add(servicio);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditServicio(Servicio servicio)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    var c = from service in context.Servicios
                            where servicio.Id == service.Id
                            select service;
                    Servicio servicio1 = c.FirstOrDefault();
                    context.Entry(servicio1).State = System.Data.Entity.EntityState.Modified;
                    servicio1.Id = servicio.Id;
                    servicio1.Nombre = servicio.Nombre;
                    servicio1.Descripcion = servicio.Descripcion;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DropServicio(Servicio servicio)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    var c = from service in context.Servicios
                            where servicio.Id == service.Id
                            select service;
                    Servicio servicioARemover = c.FirstOrDefault();
                    context.Servicios.Remove(servicioARemover);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
