using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;

namespace TallerMecanico.Logica
{
    class LogicaVehiculo
    {

        public ICollection<Vehiculo> ListarVehiculos()
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from c in context.Vehiculos
                          select c;
                return lst.ToList();
            }
        }

        public ICollection<Vehiculo> ListarVehiculosPorCliente(Cliente cliente)
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from c in context.Vehiculos
                          where c.IdCliente == cliente.Id
                          select c;
                return lst.ToList();
            }
        }

        public bool IsPlacaValid(Vehiculo vehiculo)
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from c in context.Vehiculos
                          where c.Placa == vehiculo.Placa && c.Id != vehiculo.Id
                          select c;

                return (lst.ToList().Count == 0) ? true : false;
            }
        }

        public Vehiculo GetVehiculo(Vehiculo auto)
        {
            using (ModelContext context = new ModelContext())
            {
                Vehiculo vehiculo = new Vehiculo();
                //Por placa
                if (!String.IsNullOrEmpty(auto.Placa))
                {
                    var lst = from c in context.Vehiculos
                              where c.Placa == auto.Placa
                              select c;
                    vehiculo = lst.FirstOrDefault();
                }

                //Por ID
                if (auto.Id != 0)
                {
                    var lst = from c in context.Vehiculos
                              where c.Id == auto.Id
                              select c;
                    vehiculo = lst.FirstOrDefault();
                }

                return vehiculo;
            }
        }

        public bool AddVehiculo(Vehiculo vehiculo)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {                    
                    context.Vehiculos.Add(vehiculo);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditVehiculo(Vehiculo vehiculoE)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    var v = from ve in context.Vehiculos
                            where ve.Id == vehiculoE.Id
                            select ve;
                    Vehiculo vehiculo = v.FirstOrDefault();
                    context.Entry(vehiculo).State = System.Data.Entity.EntityState.Modified;
                    
                    vehiculo.Placa = vehiculoE.Placa;
                    vehiculo.Marca = vehiculoE.Marca;
                    vehiculo.Modelo = vehiculoE.Modelo;
                    vehiculo.Color = vehiculoE.Color;
                    vehiculo.Tipo = vehiculoE.Tipo;
                    vehiculo.Anio = vehiculoE.Anio;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DropVehiculo(Vehiculo vehiculo)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    var v = from ve in context.Vehiculos
                            where ve.Id == vehiculo.Id
                            select ve;
                    Vehiculo vehiculoARemover = v.FirstOrDefault();
                    context.Vehiculos.Remove(vehiculoARemover);
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
