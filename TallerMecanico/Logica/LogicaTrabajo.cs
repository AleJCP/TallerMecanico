using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;

namespace TallerMecanico.Logica
{
    class LogicaTrabajo
    {
        //Trabajar con transacciones para setar en las otras tablas informacion

        public ICollection<TrabajoDTO> ListarTrabajosDTO()
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from t in context.Trabajos                          
                          join v in context.Vehiculos on t.IdVehiculo equals v.Id
                          join c in context.Clientes on v.IdCliente equals c.Id
                          select new TrabajoDTO()
                          {
                              Id = t.Id,
                              DatosCliente = c.Nombre+" "+c.Apellido,
                              DatosVehiculo = v.Placa+" "+v.Marca+" "+v.Modelo+" "+v.Anio,
                              Comentarios = t.Comentarios,
                              Fecha = t.Fecha
                          };

                return lst.ToList();
            }
        }        
        public int ContarTrabajosPorFecha(DateTime date)
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from t in context.Trabajos
                          where t.Fecha == date
                          select t;
                return lst.ToList().Count;
            }
        }
        public Trabajo GetTrabajo(Trabajo trabajoE)
        {
            using (ModelContext context = new ModelContext())
            {
                Trabajo trabajo = new Trabajo();
                //Por ID              
                    var lst = from t in context.Trabajos
                              where t.Id == trabajoE.Id
                              select t;
                    trabajo = lst.FirstOrDefault();              

                return trabajo;
            }
        }
        public ICollection<Servicio> GetServiciosARealizar(Trabajo trabajoE)
        {
            using (ModelContext context = new ModelContext())
            {                
                //Por ID              
                var lst = from svv in context.Servicio_Vehiculos
                          where svv.IdTrabajo == trabajoE.Id
                          select svv;
                List<Servicio> listaServiciosARealizar = new List<Servicio>();
                //Agregar servicios de acuerdo a acada fila de la tabla servicios vihuculos
                foreach(var item in lst)
                {
                    var c = from s in context.Servicios
                            where s.Id == item.IdServicio
                            select s;
                    Servicio servicio = c.FirstOrDefault() as Servicio;
                    listaServiciosARealizar.Add(servicio);
                    
                }

                return listaServiciosARealizar;
            }
        }
        public bool AddTrabajo(Trabajo trabajo,Vehiculo vehiculo,List<Servicio> serviciosARealizar)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    //context.Servicios.Add(servicio);
                    //context.SaveChanges();
                    
                    using (var DBTRANSACT = context.Database.BeginTransaction())
                    {
                        //Seteamos la info del vehiculo
                        // y agregamos el trabajo en la tabla con transacciones
                        trabajo.IdVehiculo = vehiculo.Id;
                        trabajo = context.Trabajos.Add(trabajo);

                        //Agregar Todos los servicios, DECIDIR SI CAMBIAR LA LOGICA DE LA CALVE DEL VEHICULO 
                        //MEnos es mas
                        foreach (var item in serviciosARealizar)
                        {                                                        
                            Servicio_Vehiculo sv = new Servicio_Vehiculo();
                            sv.IdTrabajo = trabajo.Id;
                            sv.IdServicio = item.Id;
                            context.Servicio_Vehiculos.Add(sv);
                        }
                        context.SaveChanges();
                        DBTRANSACT.Commit();

                        return true;
                    }
                    
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
