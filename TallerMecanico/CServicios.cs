using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;
using TallerMecanico.Logica;

namespace TallerMecanico
{
    class CServicios : ICServicios
    {
        #region Usuario
        bool ICServicios.TryLogIn(User tryUser)
        {
            return new LogicaUsers().TryLogIn(tryUser);
        }
        #endregion

        #region Cliente
        ICollection<Cliente> ICServicios.ListarClientes()
        {
            return new LogicaCliente().ListarClientes();
        }

        int ICServicios.ContarClientes()
        {
            return new LogicaCliente().ContarClientes();
        }

        bool ICServicios.IsCedulaValid(Cliente cliente)
        {
            return new LogicaCliente().IsCedulaValid(cliente);
        }

        bool ICServicios.IsTelefonoValid(Cliente cliente)
        {
            return new LogicaCliente().IsTelefonoValid(cliente);   
        }
        Cliente ICServicios.GetCliente(Cliente clienteE)
        {
            return new LogicaCliente().GetCliente(clienteE);
        }
        bool ICServicios.AddCliente(Cliente cliente)
        {
            return new LogicaCliente().AddCliente(cliente);
        }

        bool ICServicios.EditCliente(Cliente cliente)
        {
            return new LogicaCliente().EditCliente(cliente);
        }

        bool ICServicios.DropCliente(Cliente cliente)
        {
            return new LogicaCliente().DropCliente(cliente);
        }
        #endregion

        #region Servicio
        ICollection<Servicio> ICServicios.ListarServicios()
        {
            return new LogicaServicio().ListarServicios();
        }
        int ICServicios.ContarServicios()
        {
            return new LogicaServicio().ContarServicios();
        }
        bool ICServicios.AddServicio(Servicio servicio)
        {
            return new LogicaServicio().AddServicio(servicio);
        }

        bool ICServicios.EditServicio(Servicio servicio)
        {
            return new LogicaServicio().EditServicio(servicio);
        }

        bool ICServicios.DropServicio(Servicio servicio)
        {
            return new LogicaServicio().DropServicio(servicio);
        }
        #endregion

        #region Vehiculo
        ICollection<Vehiculo> ICServicios.ListarVehiculos()
        {
            return new LogicaVehiculo().ListarVehiculos();
        }
        ICollection<Vehiculo> ICServicios.ListarVehiculosPorCliente(Cliente cliente)
        {
            return new LogicaVehiculo().ListarVehiculosPorCliente(cliente);
        }
        bool ICServicios.IsPlacaValid(Vehiculo vehiculo)
        {
            return new LogicaVehiculo().IsPlacaValid(vehiculo);
        }
        Vehiculo ICServicios.GetVehiculo(Vehiculo vehiculo)
        {
            return new LogicaVehiculo().GetVehiculo(vehiculo);
        }
        bool ICServicios.AddVehiculo(Vehiculo vehiculo)
        {
            return new LogicaVehiculo().AddVehiculo(vehiculo);
        }
        bool ICServicios.EditVehiculo(Vehiculo vehiculo)
        {
            return new LogicaVehiculo().EditVehiculo(vehiculo);
        }
        bool ICServicios.DropVehiculo(Vehiculo vehiculo)
        {
            return new LogicaVehiculo().DropVehiculo(vehiculo);
        }
        #endregion

        #region TrabajoDTO
        ICollection<TrabajoDTO> ICServicios.ListarTrabajosDTO()
        {
            return new LogicaTrabajo().ListarTrabajosDTO();
        }
        int ICServicios.ContarTrabajosPorFecha(DateTime date)
        {
            return new LogicaTrabajo().ContarTrabajosPorFecha(date);
        }
        ICollection<TrabajoDTO> ICServicios.ListarTrabajosDTOFiltrado(Cliente clienteE, Vehiculo vehiculoE, DateTime? fechaE,string fechaT)
        {   
            return new LogicaTrabajo().ListarTrabajosDTOFiltrado(clienteE, vehiculoE, fechaE,fechaT);
        }        
        Trabajo ICServicios.GetTrabajo(Trabajo trabajo)
        {
            return new LogicaTrabajo().GetTrabajo(trabajo);
        }
        ICollection<Servicio> ICServicios.GetServiciosARealizar(Trabajo trabajo)
        {
            return new LogicaTrabajo().GetServiciosARealizar(trabajo);
        }
        bool ICServicios.AddTrabajo(Trabajo trabajo, Vehiculo vehiculo, List<Servicio> serviciosARealizar)
        {
            return new LogicaTrabajo().AddTrabajo(trabajo,vehiculo,serviciosARealizar);
        }

        bool ICServicios.EditTrabajo(Trabajo trabajo, Vehiculo vehiculo, List<Servicio> serviciosARealizar)
        {
            return new LogicaTrabajo().EditTrabajo(trabajo, vehiculo, serviciosARealizar);
        }

        bool ICServicios.DropTrabajo(Trabajo trabajo)
        {
            return new LogicaTrabajo().DropTrabajo(trabajo);
        }
        #endregion
    }
}
