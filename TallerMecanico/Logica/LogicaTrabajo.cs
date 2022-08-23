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
                          join sv in context.Servicio_Vehiculos on t.Id equals sv.IdTrabajo
                          join v in context.Vehiculos on sv.IdVehiculo equals v.Id
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
        //join departamento in context.Departamentos on empleado.IdDepartamento equals departamento.Id
        //TRABAJO,VEHICULO,LISTASERVICIOS
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
                        context.Trabajos.Add(trabajo);
                        

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
