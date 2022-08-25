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
                              DatosCliente = c.Nombre + " " + c.Apellido,
                              DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                              Comentarios = t.Comentarios,
                              Fecha = t.Fecha
                          };

                return lst.ToList();
            }
        }

        public ICollection<TrabajoDTO> ListarTrabajosDTOFiltrado(Cliente clienteE, Vehiculo vehiculoE, DateTime? fechaE, string fechaT)
        {
            using (ModelContext context = new ModelContext())
            {
                List<TrabajoDTO> lst = new List<TrabajoDTO>();               
                //buscar por cliente sin fecha
                if (clienteE.Id != 0 && vehiculoE.Id == 0 && fechaE.Value.Year == 1)
                {
                    var l = from t in context.Trabajos
                              join v in context.Vehiculos on t.IdVehiculo equals v.Id
                              join c in context.Clientes on v.IdCliente equals c.Id
                              where c.Id == clienteE.Id
                              //where v.Id == vehiculoE.Id
                              select new TrabajoDTO()
                              {
                                  Id = t.Id,
                                  DatosCliente = c.Nombre + " " + c.Apellido,
                                  DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                  Comentarios = t.Comentarios,
                                  Fecha = t.Fecha
                              };
                    lst = l.ToList();
                }
                //buscar por vehiculo sin fecha
                else if (vehiculoE.Id != 0 && fechaE.Value.Year == 1)
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id
                            //where c.Id == clienteE.Id
                            where v.Id == vehiculoE.Id
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }                
                //buscar por cliente con fecha (Igual a la fecha ingresada)
                else if (clienteE.Id != 0 && vehiculoE.Id == 0 && fechaE.Value.Year != 1 && fechaT.Equals("Igual"))
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id
                            where c.Id == clienteE.Id && t.Fecha == fechaE.Value                            
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }
                //buscar por vehiculo con fecha (Igual a la fecha ingresada)
                else if (vehiculoE.Id != 0 && fechaE.Value.Year != 1 && fechaT.Equals("Igual"))
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id                            
                            where v.Id == vehiculoE.Id && t.Fecha == fechaE.Value
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }
                //Buscar solo por fecha (Igual a la fecha ingresada)
                else if (clienteE.Id == 0 && vehiculoE.Id == 0 && fechaE.Value.Year != 1 && fechaT.Equals("Igual"))
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id
                            where t.Fecha == fechaE.Value
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }
                
                //buscar por cliente con fecha (Mayor a la fecha ingresada)
                else if (clienteE.Id != 0 && vehiculoE.Id == 0 && fechaE.Value.Year != 1 && fechaT.Equals("Mayor"))
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id
                            where c.Id == clienteE.Id && t.Fecha > fechaE.Value
                            //where v.Id == vehiculoE.Id
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }
                //buscar por vehiculo con fecha (Mayor a la fecha ingresada)
                else if (vehiculoE.Id != 0 && fechaE.Value.Year != 1 && fechaT.Equals("Mayor"))
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id
                            //where c.Id == clienteE.Id
                            where v.Id == vehiculoE.Id && t.Fecha > fechaE.Value
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }
                //Buscar solo por fecha (Mayor a la fecha ingresada)
                else if (clienteE.Id == 0 && vehiculoE.Id == 0 && fechaE.Value.Year != 1 && fechaT.Equals("Mayor"))
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id
                            where t.Fecha > fechaE.Value
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }                
                //buscar por cliente con fecha (Menor a la fecha ingresada)
                else if (clienteE.Id != 0 && vehiculoE.Id == 0 && fechaE.Value.Year != 1 && fechaT.Equals("Menor"))
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id
                            where c.Id == clienteE.Id && t.Fecha < fechaE.Value                            
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }
                //buscar por vehiculo con fecha (Menor a la fecha ingresada)
                else if (vehiculoE.Id != 0 && fechaE.Value.Year != 1 && fechaT.Equals("Menor"))
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id
                            //where c.Id == clienteE.Id
                            where v.Id == vehiculoE.Id && t.Fecha < fechaE.Value
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }

                //Buscar solo por fecha (Menor a la fecha ingresada)
                else if (clienteE.Id == 0 && vehiculoE.Id == 0 && fechaE.Value.Year != 1 && fechaT.Equals("Menor"))
                {
                    var l = from t in context.Trabajos
                            join v in context.Vehiculos on t.IdVehiculo equals v.Id
                            join c in context.Clientes on v.IdCliente equals c.Id
                            where t.Fecha < fechaE.Value
                            select new TrabajoDTO()
                            {
                                Id = t.Id,
                                DatosCliente = c.Nombre + " " + c.Apellido,
                                DatosVehiculo = v.Placa + " " + v.Marca + " " + v.Modelo + " " + v.Anio,
                                Comentarios = t.Comentarios,
                                Fecha = t.Fecha
                            };
                    lst = l.ToList();
                }

                return lst;
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
                var lst = from svv in context.Servicio_Vehiculos
                          where svv.IdTrabajo == trabajoE.Id
                          select svv;
                List<Servicio> listaServiciosARealizar = new List<Servicio>();
                //Agregar servicios de acuerdo a acada fila de la tabla servicios vihuculos
                foreach (var item in lst)
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
        public bool AddTrabajo(Trabajo trabajo, Vehiculo vehiculo, List<Servicio> serviciosARealizar)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {                 
                    using (var DBTRANSACT = context.Database.BeginTransaction())
                    {                                             
                        trabajo = context.Trabajos.Add(trabajo);                        
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

        public bool EditTrabajo(Trabajo trabajo, Vehiculo vehiculo, List<Servicio> serviciosARealizar)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    //Modificar la tabla trabajo (Modo edicion)
                    //Borrar todos los registros quie coincidan con el ID del trabajo
                    //Luego insertarlos nuevamente

                    using (var DBTRANSACT = context.Database.BeginTransaction())
                    {
                        var t = from job in context.Trabajos
                                where job.Id == trabajo.Id
                                select job;
                        Trabajo trabajoEditar = t.FirstOrDefault();
                        context.Entry(trabajoEditar).State = System.Data.Entity.EntityState.Modified;
                        trabajoEditar.Comentarios = trabajo.Comentarios;
                        trabajoEditar.Fecha = trabajo.Fecha;
                        trabajoEditar.IdVehiculo = trabajo.IdVehiculo;

                        ///Como es una tabla de relacion, en caso de alguna modificacion en cuanto a los servicio
                        ///Es importante eliminar todos los registros y volverlos a llenar
                        ///Lo cual mantiene una correcta integridad ed la informacion
                        ///
                        //Eliminar los servicios asociados
                        var lstServ = from sv in context.Servicio_Vehiculos
                                      where sv.IdTrabajo == trabajo.Id
                                      select sv;

                        foreach (var item in lstServ.ToList())
                        {
                            context.Servicio_Vehiculos.Remove(item);
                        }


                        context.SaveChanges();
                        //Guardamos para que permita hacer la inserción

                        //Agregar los nuevos servicios asociados
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
        public bool DropTrabajo(Trabajo trabajo)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    var lst = from t in context.Trabajos
                              where t.Id == trabajo.Id
                              select t;
                    trabajo = lst.FirstOrDefault();
                    context.Trabajos.Remove(trabajo);
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
