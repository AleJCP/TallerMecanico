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
    partial class TrabajoDialog : Form
    {
        ICServicios cServicios = new CServicios();
        Cliente clienteSeleccionado = new Cliente();
        Vehiculo vehiculoSeleccionado = new Vehiculo();
        List<Servicio> ListaServiciosARealizar = new List<Servicio>();
        string modo { get; set; }
        int IDTrabajo { get; set; }
        public TrabajoDialog(Trabajo trabajo = null,string modo = "Guardar")
        {
            InitializeComponent();            
            this.modo = modo;            
            dateEditFecha.DateTime = DateTime.Today;
            //Cargar Binding Cliente
            bindingSourceClientes.DataSource = cServicios.ListarClientes();
            lookUpECliente.Properties.DataSource = bindingSourceClientes;
            lookUpECliente.Properties.DisplayMember = "Cedula";
            lookUpECliente.Properties.KeyMember = "Cedula";
            //Cargar el Binding Servicios
            bindingSourceServicios.DataSource = cServicios.ListarServicios();
            lookUpEServicios.Properties.DataSource = bindingSourceServicios;
            lookUpEServicios.Properties.DisplayMember = "Nombre";            
            //Caso Mostrar
            if(modo == "Mostrar")
            {
                SetInfoTrabajo(trabajo);
                //Desactivamos los controles
                textComentario.Enabled = false;
                lookUpECliente.Enabled = false;
                lookUpEServicios.Enabled = false;                
                btnAddTrabajo.Enabled = false;
                btnDropTrabajo.Enabled = false;
                btnGuardar.Visible = false;
                lookUpEVehiculo.Enabled = false;

            }
            //Caso de editar
            if(trabajo != null)
            {
                SetInfoTrabajo(trabajo);                
            }
            CargarTablaTrabajo_Servicios();
        }    
        /// <summary>
        /// Hace referencia a los servicios asociados al TRABAJO o TRANSACCION
        /// </summary>
        void CargarTablaTrabajo_Servicios()
        {
            bindingSourceTrabajos.DataSource = ListaServiciosARealizar.ToList();
            gridControlTrabajos.DataSource = bindingSourceTrabajos;
        }

        void SetInfoTrabajo(Trabajo trabajo)
        {
            //Obtener el trabajo
            Trabajo trabajoEdit = cServicios.GetTrabajo(trabajo);
            IDTrabajo = trabajoEdit.Id;
            //ServiciosARealizar IdTrabajo
            List<Servicio> serviciosARealizarEdit = cServicios.GetServiciosARealizar(trabajo).ToList();
            //Vehiculo
            Vehiculo v = new Vehiculo();
            v.Id = trabajoEdit.IdVehiculo;

            Vehiculo vehiculoEdit = cServicios.GetVehiculo(v);
            //Cargar los datos del cliente,
            Cliente cliente = new Cliente();
            cliente.Id = vehiculoEdit.IdCliente;

            Cliente clienteEdit = cServicios.GetCliente(cliente);
            //Mostrar
            ListaServiciosARealizar = serviciosARealizarEdit;
            lookUpECliente.EditValue = clienteEdit;
            lookUpEVehiculo.EditValue = vehiculoEdit;
            //fecha
            dateEditFecha.DateTime = trabajoEdit.Fecha;
            textComentario.Text = trabajoEdit.Comentarios;
        }
        #region lookUpEventos        
        private void lookUpECliente_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpECliente != null)
            {                               
               clienteSeleccionado = lookUpECliente.GetSelectedDataRow() as Cliente;

                if(clienteSeleccionado == null)
                {
                    clienteSeleccionado = lookUpECliente.EditValue as Cliente;
                }
                //Seteamos info
                labelCliente.Text = $"{clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}";
                //Cargamos vehiculos
                bindingSourceVehiculos.DataSource = cServicios.ListarVehiculosPorCliente(clienteSeleccionado);
                lookUpEVehiculo.Properties.DataSource = bindingSourceVehiculos;
                lookUpEVehiculo.Properties.DisplayMember = "Placa";
                lookUpEVehiculo.Properties.KeyMember = "Placa";
                //Limpiamos la informacion de los vehiculos al seleccionar el cliente
                vehiculoSeleccionado = new Vehiculo();
                //Desactivamos el btn Guardar
                btnGuardar.Enabled = false;
                labelVehiculo.Text = "... ...";
                //Para que no me ctive el control al mostrar detalles
                if (!modo.Equals("Mostrar"))
                {
                    lookUpEVehiculo.Enabled = true;
                }
                
            }

        }

        private void lookUpEVehiculo_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEVehiculo != null)
            {
                vehiculoSeleccionado = lookUpEVehiculo.GetSelectedDataRow() as Vehiculo;
                //si no lo puede recoger con esa funcion se ejecuta esta otra
                if (vehiculoSeleccionado == null)
                {
                    vehiculoSeleccionado = lookUpEVehiculo.EditValue as Vehiculo;
                }
                //Seteamos info
                labelVehiculo.Text = $"{vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo} {vehiculoSeleccionado.Color} {vehiculoSeleccionado.Anio}";
                //Activamos el boton
                btnGuardar.Enabled = true;
            }
        }
        #endregion

        #region BtnsEventos    
        /// <summary>
        /// Se Agrega un Servicio a la Relacion Trabajo_Servicios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTrabajo_Click(object sender, EventArgs e)
        {            
            Servicio servicio = lookUpEServicios.GetSelectedDataRow() as Servicio;
            if (servicio != null)
            {
                //Comprobamos que no lo contenga
                List<Servicio> coincidencias = new List<Servicio>();
                foreach (var item in ListaServiciosARealizar)
                {
                    //comprobamos con ID
                    if(item.Id == servicio.Id)
                    {
                        coincidencias.Add(item);
                    }
                }              
                //Si no hay coincidencias, se agrega
                if (coincidencias.Count == 0)
                {
                    ListaServiciosARealizar.Add(servicio);
                    lookUpEServicios.EditValue = null;
                    CargarTablaTrabajo_Servicios();
                }
                else
                {
                    MessageBox.Show("Ya ese servicio está en la lista");
                }

            }
        }
        /// <summary>
        /// Se Elimina un Servicio a la Relacion Trabajo_Servicios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDropTrabajo_Click(object sender, EventArgs e)
        {
            Servicio servicioS = bindingSourceTrabajos.Current as Servicio;
            if (servicioS != null)
            {
                ListaServiciosARealizar.Remove(servicioS);
                CargarTablaTrabajo_Servicios();
            }
        }
        /// <summary>
        /// Se guarda el TRABAJO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Objeto Trabajo
            Trabajo trabajo = new Trabajo();
            trabajo.Id = IDTrabajo;
            trabajo.Comentarios = String.IsNullOrEmpty(textComentario.Text) ? "Sin Comentarios" : textComentario.Text;            
            trabajo.Fecha = dateEditFecha.DateTime;

            //Comprobar que este seteado un vehiculo
            if (vehiculoSeleccionado != null)
            {
                //Seteamos el vehiculo
                trabajo.IdVehiculo = vehiculoSeleccionado.Id;
                //Comprobar que haya una fecha
                if (trabajo.Fecha != null)
                {
                    if (ListaServiciosARealizar.Count > 0)
                    {
                        //Todo comprobado, se procede a agregar la operacion
                        //Se utiliza la variable modo, para ejecutar la funcion de insertar o editar en la logica
                        if (modo.Equals("Guardar"))
                        {
                            if (cServicios.AddTrabajo(trabajo,vehiculoSeleccionado,ListaServiciosARealizar))
                            {
                                this.Dispose();
                                MessageBox.Show($"Proceso Ejecutado con éxito", "Trabajo Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }                        
                        else
                        {
                            if (cServicios.EditTrabajo(trabajo, vehiculoSeleccionado, ListaServiciosARealizar))
                            {
                                this.Dispose();
                                MessageBox.Show($"Proceso Ejecutado con éxito", "Trabajo Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

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
        #endregion
    }
}
