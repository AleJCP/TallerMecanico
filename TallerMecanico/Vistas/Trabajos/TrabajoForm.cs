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
    public partial class TrabajoForm : Form
    {
        ICServicios cServicios = new CServicios();
        //Variables de Filtros
        Cliente clienteSeleccionado = new Cliente();
        Vehiculo vehiculoSeleccionado = new Vehiculo();
        DateTime? fechaSeleccionada = null;
        string fechaTipo { get; set; }

        public bool filtroEncendido { get; set; }
        public TrabajoForm()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void btnAddTrabajo_Click(object sender, EventArgs e)
        {
            Form Dialog = new TrabajoDialog();
            Dialog.ShowDialog();
            CargarTabla();
        }

        public void CargarTabla()
        {
            //Comprobamos que el filtro este encendido o no
            if (!filtroEncendido)
            {
                bindingSourceTrabajos.DataSource = cServicios.ListarTrabajosDTO();
                gridControlTrabajos.DataSource = bindingSourceTrabajos;
                labelTextShow.Text = "Mostrando Todos";
            }
            else
            {
                bindingSourceTrabajos.DataSource = cServicios.ListarTrabajosDTOFiltrado(clienteSeleccionado,vehiculoSeleccionado,fechaSeleccionada,fechaTipo);
                gridControlTrabajos.DataSource = bindingSourceTrabajos;
                labelTextShow.Text = "Filtrado";
            }
            
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            //Editar cliente
            //Capturamos el ID
            TrabajoDTO trabajoDTO = bindingSourceTrabajos.Current as TrabajoDTO;

            if(trabajoDTO != null)
            {
                //Creamos un Objeto para enviarlo al Form Dialog y le decimos que va a editar
                Trabajo trabajoSelected = new Trabajo();
                trabajoSelected.Id = trabajoDTO.Id;
                Form Dialog = new TrabajoDialog(trabajoSelected,"Editar");
                Dialog.ShowDialog();
                
                CargarTabla();
            }
        }

        private void btnDropCliente_Click(object sender, EventArgs e)
        {
            //Eliminar cliente
            //Capturamos el ID
            //Mostramos un aviso para eliminarlo o no
            TrabajoDTO trabajoDTO = bindingSourceTrabajos.Current as TrabajoDTO;
            Trabajo trabajoSelected = new Trabajo();
            trabajoSelected.Id = trabajoDTO.Id;

            if (trabajoDTO != null)
            {
                if (MessageBox.Show($"Se eliminará el Vehiculo con el ID: {trabajoSelected.Id}? Toda la informacion asociada al Trabajo se eliminará", "Eliminar Trabajo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    
                    if (cServicios.DropTrabajo(trabajoSelected))
                    {
                        MessageBox.Show($"Proceso Ejecutado con éxito", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTabla();
                    }
                    else
                    {
                        MessageBox.Show($"Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnFiltrarXCliente_Click(object sender, EventArgs e)
        {            
            Form Dialog = new TrabajoFiltroDialog(this);
            Dialog.Show();
            CargarTabla();
        }
        /// <summary>
        /// Funcion que se llama desde el Dialogo de los Filtros TrabajoFiltroDialog para setear los parametros
        /// </summary>
        /// <param name="clienteS"></param>
        /// <param name="vehiculoS"></param>
        /// <param name="fechaS"></param>
        /// <param name="fechaTipo"></param>
        public void AplicarFiltros(Cliente clienteS,Vehiculo vehiculoS,DateTime? fechaS, string fechaTipo)
        {
            //Seteamos las variables del filtro
            clienteSeleccionado = clienteS;
            vehiculoSeleccionado = vehiculoS;
            fechaSeleccionada = fechaS;
            filtroEncendido = true;
            this.fechaTipo = fechaTipo;
            CargarTabla();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = null;
            vehiculoSeleccionado = null;
            fechaSeleccionada = null;
            filtroEncendido = false;
            CargarTabla();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            TrabajoDTO trabajoDTO = bindingSourceTrabajos.Current as TrabajoDTO;

            if (trabajoDTO != null)
            {
                Trabajo trabajoSelected = new Trabajo();
                trabajoSelected.Id = trabajoDTO.Id;
                Form Dialog = new TrabajoDialog(trabajoSelected, "Mostrar");
                Dialog.ShowDialog();
                CargarTabla();
            }
        }
    }
}
