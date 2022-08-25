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
        //Se llama al dialogo paraEditar un Servicio Realizado o trabajo existente
        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            TrabajoDTO trabajoDTO = bindingSourceTrabajos.Current as TrabajoDTO;

            if(trabajoDTO != null)
            {
                Trabajo trabajoSelected = new Trabajo();
                trabajoSelected.Id = trabajoDTO.Id;
                Form Dialog = new TrabajoDialog(trabajoSelected,"Editar");
                Dialog.ShowDialog();
                CargarTabla();
            }
        }
        //Se pregunta el dialogo, para eliminar
        private void btnDropCliente_Click(object sender, EventArgs e)
        {
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {            
            Form Dialog = new TrabajoFiltroDialog(this);
            Dialog.Show();
            CargarTabla();
        }

        public void AplicarFiltros(Cliente clienteS,Vehiculo vehiculoS,DateTime? fechaS, string fechaTipo)
        {
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
