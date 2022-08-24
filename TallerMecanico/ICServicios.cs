using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;

namespace TallerMecanico
{
    interface ICServicios
    {
        #region Usuario
        bool TryLogIn(User tryUser);
        #endregion

        #region Cliente
        ICollection<Cliente> ListarClientes();
        int ContarClientes();
        bool IsCedulaValid(Cliente cliente);
        bool IsTelefonoValid(Cliente cliente);
        Cliente GetCliente(Cliente clienteE);
        bool AddCliente(Cliente cliente);
        bool EditCliente(Cliente cliente);
        bool DropCliente(Cliente cliente);
        #endregion

        #region Servicio
        ICollection<Servicio> ListarServicios();
        int ContarServicios();
        bool AddServicio(Servicio servicio);
        bool EditServicio(Servicio servicio);
        bool DropServicio(Servicio servicio);
        #endregion

        #region Vehiculo
        ICollection<Vehiculo> ListarVehiculos();
        ICollection<Vehiculo> ListarVehiculosPorCliente(Cliente cliente);
        bool IsPlacaValid(Vehiculo vehiculo);        
        Vehiculo GetVehiculo(Vehiculo vehiculo);
        bool AddVehiculo(Vehiculo vehiculo);
        bool EditVehiculo(Vehiculo vehiculo);
        bool DropVehiculo(Vehiculo vehiculo);
        #endregion

        #region TrabajoDTO
        ICollection<TrabajoDTO> ListarTrabajosDTO();
        Trabajo GetTrabajo(Trabajo trabajo);
        ICollection<Servicio> GetServiciosARealizar(Trabajo trabajo);
        bool AddTrabajo(Trabajo trabajo, Vehiculo vehiculo, List<Servicio> serviciosARealizar);
        bool EditTrabajo(Trabajo trabajo, Vehiculo vehiculo, List<Servicio> serviciosARealizar);
        bool DropTrabajo(Trabajo trabajo);
        #endregion
    }
}
