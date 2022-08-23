using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico.Entidades;

namespace TallerMecanico.Vistas.Trabajos
{
    public partial class TrabajoDialog : Form
    {
        ICServicios cServicios = new CServicios();
        Cliente clienteSeleccionado = new Cliente();
        Vehiculo vehiculoSeleccionado = new Vehiculo();
        List<Servicio> ListaServiciosARealizar = new List<Servicio>();
        public TrabajoDialog()
        {
            InitializeComponent();
            //Cargar Binding Cliente, al seleccionar un Cliente Se carga la listade los vehiculos que posee el cliente
            bindingSourceClientes.DataSource = cServicios.ListarClientes();
            lookUpECliente.Properties.DataSource = bindingSourceClientes;
            lookUpECliente.Properties.DisplayMember = "Cedula";
            //Cargar el Binding de los Servicios
            bindingSourceServicios.DataSource = cServicios.ListarServicios();
            lookUpEServicios.Properties.DataSource = bindingSourceServicios;
            lookUpEServicios.Properties.DisplayMember = "Nombre";

            CargarTablaTrabajos();
        }
        void CargarTablaTrabajos()
        {
            bindingSourceTrabajos.DataSource = ListaServiciosARealizar.ToList();
            gridControlTrabajos.DataSource = bindingSourceTrabajos;
        }
        private void lookUpECliente_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpECliente != null)
            {
                clienteSeleccionado = lookUpECliente.GetSelectedDataRow() as Cliente;
                //Seteamos info
                labelCliente.Text = $"{clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}";
                //Cargamos vehiculos
                bindingSourceVehiculos.DataSource = cServicios.ListarVehiculosPorCliente(clienteSeleccionado);
                lookUpEVehiculo.Properties.DataSource = bindingSourceVehiculos;
                lookUpEVehiculo.Properties.DisplayMember = "Placa";
                //Limpiamos la informacion de los vehiculos al seleccionar el cliente
                vehiculoSeleccionado = new Vehiculo();
                //Desactivamos el btn Guardar
                btnGuardar.Enabled = false;
                labelVehiculo.Text = "... ...";
                lookUpEVehiculo.Enabled = true;
            }

        }

        private void lookUpEVehiculo_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEVehiculo != null)
            {
                vehiculoSeleccionado = lookUpEVehiculo.GetSelectedDataRow() as Vehiculo;
                //Seteamos info
                labelVehiculo.Text = $"{vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo} {vehiculoSeleccionado.Color} {vehiculoSeleccionado.Anio}";
                //Activamos el boton
                btnGuardar.Enabled = true;
            }
        }

        private void btnSetToday_Click(object sender, EventArgs e)
        {
            dateEditFecha.DateTime = DateTime.Today;
        }

        private void btnAddTrabajo_Click(object sender, EventArgs e)
        {
            Servicio servicio = lookUpEServicios.GetSelectedDataRow() as Servicio;
            if (servicio != null)
            {
                //Comprobamos que no lo contenga
                if (!ListaServiciosARealizar.Contains(servicio))
                {
                    ListaServiciosARealizar.Add(servicio);
                    lookUpEServicios.EditValue = null;
                    CargarTablaTrabajos();
                }
                else
                {
                    MessageBox.Show("Ya ese servicio está en la lista");
                }

            }
        }

        private void btnDropTrabajo_Click(object sender, EventArgs e)
        {
            Servicio servicioS = bindingSourceTrabajos.Current as Servicio;
            if (servicioS != null)
            {
                ListaServiciosARealizar.Remove(servicioS);
                CargarTablaTrabajos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Comprobar que este seteado un vehiculo
            if (vehiculoSeleccionado != null)
            {
                //Comprobar que haya una fecha y sea igual o mayor que hoy
                if (dateEditFecha.DateTime != null && dateEditFecha.DateTime >= DateTime.Today)
                {
                    if (ListaServiciosARealizar.Count > 0)
                    {
                        //Todo comprobado, se procede a agregar la operacion
                        //Agregar Trabajo, Vehiculo, ListaServicios

                    }
                    else
                    {
                        MessageBox.Show($"Debes seleccionar al menos un (1) Servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show($"Debes seleccionar una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"No hay un vehículo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
