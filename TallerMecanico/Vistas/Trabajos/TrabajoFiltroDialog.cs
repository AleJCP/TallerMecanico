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
    public partial class TrabajoFiltroDialog : Form
    {
        ICServicios cServicios = new CServicios();
        TrabajoForm trabajoForm;
        string modo { get; set; }
        string fechaTipo { get; set; }
        //Variables de Filtros
        Cliente clienteSeleccionado = new Cliente();
        Vehiculo vehiculoSeleccionado = new Vehiculo();
        DateTime? fechaSeleccionada = null;

        public TrabajoFiltroDialog(TrabajoForm trabajoForm, ICollection<Object> coleccion = null, string modo = "Aplicar")
        {
            InitializeComponent();
            this.trabajoForm = trabajoForm;
            //setar bindings
            bindingSourceClientes.DataSource = cServicios.ListarClientes();
            lookUpECliente.Properties.DataSource = bindingSourceClientes;
            lookUpECliente.Properties.DisplayMember = "Cedula";
            lookUpECliente.Properties.KeyMember = "Cedula";

            if (modo.Equals("Editar"))
            {
                //setear la info de la coleccion
            }

        }

        private void lookUpECliente_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpECliente != null)
            {
                clienteSeleccionado = lookUpECliente.GetSelectedDataRow() as Cliente;

                if (clienteSeleccionado == null)
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
                labelVehiculo.Text = "... ...";
                lookUpEVehiculo.Enabled = true;
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
            }
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            //Capturar objetos
            fechaSeleccionada = dateEditFecha.DateTime;
            if(fechaSeleccionada != null)
            {
                if (radioButtonIgual.Checked)
                {
                    fechaTipo = "Igual";
                }else if (radioButtonMayor.Checked)
                {
                    fechaTipo = "Mayor";
                }else if (radioButtonMenor.Checked)
                {
                    fechaTipo = "Menor";
                }
                else
                {
                    MessageBox.Show("Debes Seleccionar un comportamiento para la fecha");
                }
            }            

            if(clienteSeleccionado == null && vehiculoSeleccionado == null && fechaSeleccionada == null)
            {
                MessageBox.Show("Para aplicar el filtro debes usar al menos un campo");
            }
            else
            {
                //Funcion aplicar filtros
                trabajoForm.AplicarFiltros(clienteSeleccionado,vehiculoSeleccionado,fechaSeleccionada,fechaTipo);
            }
            //Recuerda la restriccion de la fecha que no permite editarla si es una fecha anterior a hoy
        }
    }
}
